using BankingApplication.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Mappings
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Table("Accounts");
            Id(x => x.AccountId);
            Map(x => x.AccountNumber).Not.Nullable().Unique();
            Map(x => x.AccountHolderName).Not.Nullable();
            Map(x => x.Balance).Not.Nullable();
            Map(x => x.UnclearedBalance).Not.Nullable();
            Map(x => x.IFSCode).Not.Nullable();
            Map(x => x.IsActive).Not.Nullable();
            Map(x => x.CreatedBy).Not.Nullable();
            Map(x => x.CreatedOn).Not.Nullable().Default("GETDATE()");
            Map(x => x.ModifiedBy).Not.Nullable();
            Map(x => x.ModifiedOn).Not.Nullable().Default("GETDATE()").Update();

            HasMany(x => x.Deposits).Cascade.All();
            HasMany(x => x.Withdrawals).Cascade.All();
            HasMany(x => x.Ledgers).Cascade.All();
            HasMany(x => x.BalanceHistories).Cascade.All();
        }
    }

}