using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class Account
    {
        public virtual int AccountId { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string AccountHolderName { get; set; }
        public virtual decimal Balance { get; set; }
        public virtual decimal UnclearedBalance { get; set; }
        public virtual string IFSCode { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }

        public virtual IList<Deposit> Deposits { get; set; } = new List<Deposit>();
        public virtual IList<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();
        public virtual IList<Ledger> Ledgers { get; set; } = new List<Ledger>();
        public virtual IList<BalanceHistory> BalanceHistories { get; set; } = new List<BalanceHistory>();
    }

}