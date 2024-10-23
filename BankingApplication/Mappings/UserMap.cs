using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.UserId);
            Map(x => x.LoginId).Not.Nullable().Unique();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.FullName).Not.Nullable();
            Map(x => x.Email).Not.Nullable();
            Map(x => x.IsActive).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();

            HasMany(x => x.UserRoles).Cascade.All();
            //HasMany(x => x.AccessLogs).Cascade.All();
        }
    }

}