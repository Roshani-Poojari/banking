using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string LoginId { get; set; }
        public virtual string Password { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Email { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }

        public virtual IList<UserRole> UserRoles { get; set; } = new List<UserRole>();
        //public virtual IList<AccessLog> AccessLogs { get; set; } = new List<AccessLog>();
    }

}