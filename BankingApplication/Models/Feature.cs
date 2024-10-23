using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class Feature
    {
        public virtual int FeatureId { get; set; }
        public virtual string FeatureName { get; set; }
        public virtual bool Viewable { get; set; }
        public virtual bool Creatable { get; set; }
        public virtual bool Updatable { get; set; }
        public virtual bool Deletable { get; set; }
        public virtual bool Approvable { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }

        public virtual IList<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }

}