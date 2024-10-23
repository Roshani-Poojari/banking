using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class AccessLogMap : ClassMap<AccessLog>
    {
        public AccessLogMap()
        {
            Table("AccessLog");
            Id(x => x.AccessLogId);
            Map(x => x.AccessDateTime).Not.Nullable();
            References(x => x.User).Column("UserId").Not.Nullable();
            Map(x => x.FeatureName).Not.Nullable();
            Map(x => x.ActionType).Not.Nullable();
            Map(x => x.TransactionReferenceNumber).Nullable();
        }
    }

}