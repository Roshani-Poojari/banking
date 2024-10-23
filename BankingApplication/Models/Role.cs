using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class Role
    {
        public virtual int RoleId { get; set; }
        public virtual string RoleName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }

        public virtual IList<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public virtual IList<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }

}