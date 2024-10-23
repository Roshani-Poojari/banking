using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class WithdrawalMap : ClassMap<Withdrawal>
    {
        public WithdrawalMap()
        {
            Table("Withdrawals");
            Id(x => x.WithdrawalId);
            //References(x => x.Account).Column("AccountId").Not.Nullable();
            References(x => x.Account).Column("AccountNumber").PropertyRef("AccountNumber").Not.Nullable();
            Map(x => x.Amount).Not.Nullable();
            Map(x => x.WithdrawalDateTime).Not.Nullable();
            Map(x => x.WithdrawalStatus).Not.Nullable();
            Map(x => x.TransactionReferenceNumber).Nullable();
            Map(x => x.UTRNumber).Nullable();
            Map(x => x.Narration).Nullable();
            Map(x => x.ApprovedBy).Nullable();
            Map(x => x.ApprovedOn).Nullable();
            Map(x => x.Remarks).Nullable();
            Map(x => x.IsDeleted).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();
        }
    }

}