using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingArea.Models
{
    public class AuditLog
    {
        public int AuditLogID { get; set; }
        public int UserId { get; set; }
        public DateTime EventDateUTC { get; set; }
        public string EventType { get; set; }
        public string TableName { get; set; }

        public string ColumnName { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }          
    }
}