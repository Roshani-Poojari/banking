using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class Withdrawal
    {
        public virtual int WithdrawalId { get; set; }
        public virtual Account Account { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime WithdrawalDateTime { get; set; }
        public virtual string WithdrawalStatus { get; set; }
        public virtual string TransactionReferenceNumber { get; set; }
        public virtual string UTRNumber { get; set; }
        public virtual string Narration { get; set; }
        public virtual string ApprovedBy { get; set; }
        public virtual DateTime? ApprovedOn { get; set; }
        public virtual string Remarks { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }
    }

}