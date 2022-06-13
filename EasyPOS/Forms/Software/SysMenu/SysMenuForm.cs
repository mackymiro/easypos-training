using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.SysMenu
{
    public partial class SysMenuForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public const int WM_CLOSE = 0x10;

        public SysMenuForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("SysMenu");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var sysCurrent = Modules.SysCurrentModule.GetCurrentSettings();
            if (sysCurrent.POSType == "POS Touch")
            {
                buttonPOS.ImageIndex = 14;
            }
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstItem");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageItemList();
                buttonItem.Focus();
            }
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            if (Modules.SysCurrentModule.GetCurrentSettings().TenantOf == "RLC")
            {
                //var filename = @"C:\Robinsons\";

                //string[] files = Directory.GetFiles(filename);
                //if (files.Length != 0)
                //{
                //    MessageBox.Show("Previous EOD was not performed", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                String lastEODDate = Modules.SysCurrentModule.GetCurrentSettings().EODPerformedDate;
                String minusDate = DateTime.Now.Date.AddDays(-1).ToShortDateString();
                String addDate = DateTime.Now.Date.AddDays(1).ToShortDateString();
                if (DateTime.Parse(lastEODDate) < DateTime.Parse(DateTime.Now.Date.AddDays(-1).ToShortDateString()))
                {
                    MessageBox.Show("Previous EOD was not performed", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lastEODDate != minusDate)
                {
                    MessageBox.Show("Previous EOD was not performed", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sysUserRights = new Modules.SysUserRightsModule("TrnSales");
                    if (sysUserRights.GetUserRights() == null)
                    {
                        MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var sysCurrent = Modules.SysCurrentModule.GetCurrentSettings();
                        if (sysCurrent.POSType == "POS Touch")
                        {
                            sysSoftwareForm.AddTabPagePOSTouchSalesList();
                        }
                        else if (sysCurrent.POSType == "POS Barcode")
                        {
                            sysSoftwareForm.AddTabPagePOSSalesList();
                        }
                        else
                        {
                            sysSoftwareForm.AddTabPagePOSTouchQuickServiceSalesList();
                        }
                    }
                }

            }
            else
            {
                sysUserRights = new Modules.SysUserRightsModule("TrnSales");
                if (sysUserRights.GetUserRights() == null)
                {
                    MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sysCurrent = Modules.SysCurrentModule.GetCurrentSettings();
                    if (sysCurrent.POSType == "POS Touch")
                    {
                        sysSoftwareForm.AddTabPagePOSTouchSalesList();
                    }
                    else if (sysCurrent.POSType == "POS Barcode")
                    {
                        sysSoftwareForm.AddTabPagePOSSalesList();
                    }
                    else
                    {
                        sysSoftwareForm.AddTabPagePOSTouchQuickServiceSalesList();
                    }
                }
            }

        }

        private void buttonDiscounting_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstDiscount");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageDiscountingList();
            }
        }

        private void buttonPOSReport_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepPOS");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPagePOSReport();
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstUser");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageUserList();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysSettings");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSettings();
            }
        }

        private void buttonSalesReport_OnClick(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepSales");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSalesReport();
            }
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstCustomer");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageCustomerList();
            }
        }

        private void buttonStockIn_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockIn");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockInList();
            }
        }

        private void buttonStockOut_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockOut");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockOutList();
            }
        }

        private void buttonDisbursement_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnDisbursement");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageDisbursementList();
            }
        }

        private void buttonSystemTables_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysTables");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSystemTables();
            }
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepInventory");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageInventoryReports();
            }
        }

        private void buttonRemittanceReport_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepDisbursement");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageRemittanceReports();
            }
        }

        private void buttonStockCount_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockCount");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockCountList();
            }
        }

        private void buttonUtilities_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysUtilities");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageUtilities();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //var filename = @"C:\Robinsons\";
            //string[] files = Directory.GetFiles(filename);
            //String destination = @"./../IT_Tenants";
            //String host = Modules.SysCurrentModule.GetCurrentSettings().RLCServerIP;
            //String username = "accredit";
            //String password = "RLC@Partners";
            //Int32 port = 22;

            //Task resending = Task.Run(() =>
            //{
            //    if (Modules.SysCurrentModule.GetCurrentSettings().TenantOf == "RLC")
            //    {
            //        Boolean IsConnected = NetworkInterface.GetIsNetworkAvailable();
            //        if (IsConnected == true)
            //        {
            //            if (files.Length != 0)
            //            {
            //                KillMessageBox();
            //                MessageBox.Show("Trying to send unsent files...", "EasyPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //                Modules.SysSFTPModule sysSFTPModule = new Modules.SysSFTPModule(host, username, password, files.FirstOrDefault(), destination, port);
            //                sysSFTPModule.SyncWork();
            //                KillMessageBox();
            //            }
            //        }
            //    }
            //});
        }

        public void ResendRLCFile()
        {
            if (Modules.SysCurrentModule.GetCurrentSettings().TenantOf == "RLC")
            {
                var filename = @"C:\Robinsons\";
                var directory = new DirectoryInfo(filename);
                Controllers.SysAuditTrailController sysAuditTrailController = new Controllers.SysAuditTrailController();

                if (directory.GetFiles().Any())
                {

                    var myFile = directory.GetFiles()
                        .Where(f => f.LastWriteTime.Date == DateTime.Now.Date).OrderByDescending(f => f.LastWriteTime.Date == DateTime.Now.Date)
                        .FirstOrDefault();
                    if (myFile != null)
                    {
                        String RLCSentFile = sysAuditTrailController.getFileName(myFile.FullName.Substring(13));
                        if (RLCSentFile == "")
                        {
                            String destination = @"./../IT_Tenants";
                            String host = Modules.SysCurrentModule.GetCurrentSettings().RLCServerIP;
                            String username = "accredit";
                            String password = "RLC@Partners";
                            Int32 port = 22;
                            Boolean IsConnected = NetworkInterface.GetIsNetworkAvailable();
                            if (IsConnected == true)
                            {
                                if (myFile.Length != 0)
                                {
                                    KillMessageBox();
                                    MessageBox.Show("Trying to send unsent files...", "EasyPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    Modules.SysSFTPModule.ResendingFile(host, username, password, myFile.FullName, destination, port);
                                    KillMessageBox();
                                    MessageBox.Show("Sales file is successfully send.", "EasyPOS", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Modules.SysCurrentModule.GetCurrentSettings().TenantOf == "RLC")
            {
                var filename = @"C:\Robinsons\";
                var directory = new DirectoryInfo(filename);
                
                if (directory.GetFiles().Any())
                {
                    var myFile = directory.GetFiles()
                       .Where(f => f.LastWriteTime.Date == DateTime.Now.Date).OrderByDescending(f => f.LastWriteTime.Date == DateTime.Now.Date)
                       .FirstOrDefault();
                    if (myFile != null)
                    {
                        Boolean IsConnected = NetworkInterface.GetIsNetworkAvailable();
                        if (IsConnected == true)
                        {
                            if (myFile.Length != 0)
                            {
                                ResendRLCFile();
                            }
                        }
                    }
                }
            }
        }

        private void KillMessageBox()
        {
            //Find the pop-up window of MessageBox, pay attention to the title of MessageBox
            IntPtr ptr = FindWindow(null, "EasyPOS");
            if (ptr != IntPtr.Zero)
            {
                //Close the window when found
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }

    }
}
