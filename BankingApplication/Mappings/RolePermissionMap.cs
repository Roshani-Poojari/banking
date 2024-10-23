using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class RolePermissionMap : ClassMap<RolePermission>
    {
        public RolePermissionMap()
        {
            Table("RolePermissions");
            Id(x => x.RolePermissionId);
            References(x => x.Role).Column("RoleId").Not.Nullable();
            References(x => x.Feature).Column("FeatureId").Not.Nullable();
            Map(x => x.CanView).Not.Nullable();
            Map(x => x.CanCreate).Not.Nullable();
            Map(x => x.CanUpdate).Not.Nullable();
            Map(x => x.CanDelete).Not.Nullable();
            Map(x => x.CanApprove).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();
        }
    }

}