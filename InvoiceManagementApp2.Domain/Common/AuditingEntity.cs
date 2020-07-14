using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp2.Domain.Common
{
    public class AuditingEntity
    {
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
