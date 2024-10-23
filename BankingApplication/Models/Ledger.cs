using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class Ledger
    {
        public virtual int LedgerId { get; set; }
        public virtual int TransactionId { get; set; } 
        public virtual Account Account { get; set; }
        public virtual bool IsCredit { get; set; }
        public virtual decimal TransactionAmount { get; set; }
        public virtual DateTime TransactionDate { get; set; }
        public virtual DateTime TransactionDateTime { get; set; }
        public virtual string TransactionType { get; set; }
        public virtual string Narration { get; set; }
        public virtual string TransactionReferenceNumber { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }
    }

}