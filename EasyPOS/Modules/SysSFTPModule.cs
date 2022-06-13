using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using FluentFTP;
namespace EasyPOS.Modules
{
    class SysSFTPModule
    {
        public String destination;
        public String host;
        public String username;
        public String password;
        public String fileText;
        public Int32 port;
        public SysSFTPModule(String hostIP, String user, String pass, String Textfile, String path, Int32 sftpPort)
        {
            destination = path;
            host = hostIP;
            username = user;
            password = pass;
            port = sftpPort;
            fileText = Textfile;
        }

        public async void SyncWork()
        {
            if(host.Length != 0)
            {
                var filename = @"C:\Robinsons\";
                string[] files = Directory.GetFiles(filename);
                if (files.Length != 0)
                {
                    foreach (var file in files)
                    {
                        ResendingFile(host, username, password, file, destination, port);
                    }
                    MessageBox.Show("Sales file is successfully send.", "EasyPOS", MessageBoxButtons.OK, MessageBoxIcon.None);

                   
                }
            }
            else
            {
                MessageBox.Show("Sales file is not sent to RLC server.  Please contact your POS vendor.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
        public static void CopyFile(String host, String sourceFile)
        {
            if (sourceFile != "")
            {
                if (!Directory.Exists(@"\\192.168.254.101\Users\SharedFile"))
                {
                    Directory.CreateDirectory(@"\\192.168.254.101\Users\SharedFile");
                }
                foreach (string newpath in Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newpath, newpath.Replace(sourceFile, @"\\192.168.254.101\Users\SharedFile\"), true);
                }
                //Deleting Files
                //DirectoryInfo di = new DirectoryInfo(@"C:\Robinsons");
                //FileInfo[] files = di.GetFiles();
                //foreach (FileInfo file in files)
                //{
                //    file.Delete();
                //}
                MessageBox.Show("Sales file is successfully send.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Sales file is not sent to RLC server.  Please contact your POS vendor.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }



        public static void UploadFile(String host, String username, String password,
            String sourceFile, String destinationPath, Int32 port)
        {
            using (SftpClient client = new SftpClient(host, port, username, password))
            {

                //Ping ping = new Ping();
                //String localPing = "127.0.0.1";
                //IPAddress address = IPAddress.Parse(localPing);
                //PingReply pingReply = ping.Send(address);

                Boolean IsConnected = NetworkInterface.GetIsNetworkAvailable();
                if (IsConnected == true)
                {
                    if(host.Any())
                    {
                        client.Connect();
                        client.ChangeDirectory(destinationPath);
                        using (FileStream fs = new FileStream(sourceFile, FileMode.Open))
                        {
                            client.BufferSize = 4 * 1024;
                            client.UploadFile(fs, Path.GetFileName(sourceFile));
                            Entities.SysRLCAuditTrailEntity newAuditTrail = new Entities.SysRLCAuditTrailEntity()
                            {
                                UserId = SysCurrentModule.GetCurrentSettings().CurrentUserId,
                                AuditDate = DateTime.Now,
                                ActionInformation = "File sent to RLC" + " " + sourceFile.Substring(13)
                            };
                            SysRLCAuditTrailModule.InsertRLCAuditTrail(newAuditTrail);
                            MessageBox.Show("Sales file is successfully send.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        //Deleting Files
                        //DirectoryInfo di = new DirectoryInfo(@"C:\Robinsons");
                        //FileInfo[] files = di.GetFiles();
                        //foreach (FileInfo file in files)
                        //{
                        //    file.Delete();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Sales file is not sent to RLC server.  Please contact your POS vendor.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Sales file is not sent to RLC server.  Please contact your POS vendor.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

        }

        public static void ResendingFile(String host, String username, String password,
           String sourceFile, String destinationPath, Int32 port)
        {
            try
            {
                using (SftpClient client = new SftpClient(host, port, username, password))
                {
                    Boolean IsConnected = NetworkInterface.GetIsNetworkAvailable();
                    if (IsConnected == true)
                    {
                        client.Connect();
                        client.ChangeDirectory(destinationPath);
                        using (FileStream fs = new FileStream(sourceFile, FileMode.Open))
                        {
                            client.BufferSize = 4 * 1024;
                            client.UploadFile(fs, Path.GetFileName(sourceFile));

                            Entities.SysRLCAuditTrailEntity newAuditTrail = new Entities.SysRLCAuditTrailEntity()
                            {
                                UserId = SysCurrentModule.GetCurrentSettings().CurrentUserId,
                                AuditDate = DateTime.Now,
                                ActionInformation = "File sent to RLC" + " " + sourceFile.Substring(13)
                            };
                            SysRLCAuditTrailModule.InsertRLCAuditTrail(newAuditTrail);
                        }
                        //Deleting Files
                        //DirectoryInfo di = new DirectoryInfo(@"C:\Robinsons");
                        //FileInfo[] files = di.GetFiles();
                        //foreach (FileInfo file in files)
                        //{
                        //    file.Delete();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Sales file is not sent to RLC server.  Please contact your POS vendor.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
