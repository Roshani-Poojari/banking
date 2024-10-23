using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class BalanceHistoryMap : ClassMap<BalanceHistory>
    {
        public BalanceHistoryMap()
        {
            Table("BalanceHistory");
            Id(x => x.BalanceHistoryId);
            References(x => x.Account).Column("AccountId").Not.Nullable();
            Map(x => x.Date).Not.Nullable();
            Map(x => x.ClosingBalance).Not.Nullable();
            Map(x => x.UnclearedBalance).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
        }
    }

}