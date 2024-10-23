using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class FeatureMap : ClassMap<Feature>
    {
        public FeatureMap()
        {
            Table("Features");
            Id(x => x.FeatureId);
            Map(x => x.FeatureName).Not.Nullable();
            Map(x => x.Viewable).Not.Nullable();
            Map(x => x.Creatable).Not.Nullable();
            Map(x => x.Updatable).Not.Nullable();
            Map(x => x.Deletable).Not.Nullable();
            Map(x => x.Approvable).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();

            HasMany(x => x.RolePermissions).Cascade.All();
        }
    }

}