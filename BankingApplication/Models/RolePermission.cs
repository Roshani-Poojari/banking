using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class RolePermission
    {
        public virtual int RolePermissionId { get; set; }
        public virtual Role Role { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual bool CanView { get; set; }
        public virtual bool CanCreate { get; set; }
        public virtual bool CanUpdate { get; set; }
        public virtual bool CanDelete { get; set; }
        public virtual bool CanApprove { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }
    }

}