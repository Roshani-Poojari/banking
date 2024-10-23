using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class AccessLog
    {
        public virtual int AccessLogId { get; set; }
        public virtual DateTime AccessDateTime { get; set; }
        public virtual User User { get; set; }
        public virtual string FeatureName { get; set; }
        public virtual string ActionType { get; set; }
        public virtual string TransactionReferenceNumber { get; set; }
    }

}