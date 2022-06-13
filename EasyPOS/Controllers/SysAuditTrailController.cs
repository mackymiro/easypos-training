using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class SysAuditTrailController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ============
        // List Account
        // ============
        public List<Entities.SysAuditTrailEntity> ListAuditTrail(DateTime startDate, DateTime endDate, Int32 userId)
        {
            var auditTrail = from d in db.SysAuditTrails
                             where d.AuditDate.Date >= startDate.Date
                             && d.AuditDate.Date <= endDate.Date
                             && d.UserId == userId
                             select new Entities.SysAuditTrailEntity
                             {
                                 Id = d.Id,
                                 UserId = d.UserId,
                                 User = d.MstUser.FullName,
                                 AuditDate = d.AuditDate,
                                 TableInformation = d.TableInformation,
                                 RecordInformation = d.RecordInformation,
                                 FormInformation = d.FormInformation,
                                 ActionInformation = d.ActionInformation
                             };

            return auditTrail.OrderByDescending(d => d.Id).ToList();
        }

        public List<Entities.MstUserEntity> DropDownUserList()
        {
            var users = from d in db.MstUsers
                        where d.IsLocked == true
                        select new Entities.MstUserEntity
                        {
                            Id = d.Id,
                            FullName = d.FullName
                        };

            return users.OrderByDescending(d => d.Id).ToList();
        }

        public List<Entities.MstItemEntity> DropDownItemList()
        {
            var items = from d in db.MstItems
                        where d.IsLocked == true
                        && d.IsInventory == true
                        select new Entities.MstItemEntity
                        {
                            Id = d.Id,
                            ItemDescription = d.ItemDescription
                        };

            return items.OrderByDescending(d => d.Id).ToList();
        }

        public List<Entities.SysRLCAuditTrailEntity> ListRLCAuditTrail(DateTime startDate, DateTime endDate, Int32 userId)
        {
            var auditTrail = from d in db.SysRLCAuditTrails
                             where d.SentDate.Date >= startDate.Date
                             && d.SentDate.Date <= endDate.Date
                             && d.UserId == userId
                             select new Entities.SysRLCAuditTrailEntity
                             {
                                 Id = d.Id,
                                 UserId = d.UserId,
                                 User = d.MstUser.FullName,
                                 AuditDate = d.SentDate,
                                 ActionInformation = d.ActionTaken
                             };

            return auditTrail.OrderByDescending(d => d.Id).ToList();
        }
        public String getFileName(String filename)
        {
            String fileName = "";
            var rlcTrail = from d in db.SysRLCAuditTrails
                           where d.ActionTaken.Substring(16) == filename
                           select d;
            if (rlcTrail.Any())
            {
                foreach(var rlc in rlcTrail)
                {
                    fileName =  rlc.ActionTaken.Substring(0, 17);
                }
            }
            return fileName;
        }
    }
}
