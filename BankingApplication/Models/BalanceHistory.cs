using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class BalanceHistory
    {
        public virtual int BalanceHistoryId { get; set; }
        public virtual Account Account { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal ClosingBalance { get; set; }
        public virtual decimal UnclearedBalance { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
    }

}
