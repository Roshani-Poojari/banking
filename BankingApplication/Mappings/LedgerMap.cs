using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class LedgerMap : ClassMap<Ledger>
    {
        public LedgerMap()
        {
            Table("Ledger");
            Id(x => x.LedgerId);
            Map(x => x.TransactionId).Not.Nullable();
            //References(x => x.Account).Column("AccountId").Not.Nullable();
            References(x => x.Account).Column("AccountNumber").PropertyRef("AccountNumber").Not.Nullable();
            Map(x => x.IsCredit).Not.Nullable();
            Map(x => x.TransactionAmount).Not.Nullable();
            Map(x => x.TransactionDate).Not.Nullable();
            Map(x => x.TransactionDateTime).Not.Nullable();
            Map(x => x.TransactionType).Not.Nullable();
            Map(x => x.Narration).Nullable();
            Map(x => x.TransactionReferenceNumber).Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();
        }
    }

}