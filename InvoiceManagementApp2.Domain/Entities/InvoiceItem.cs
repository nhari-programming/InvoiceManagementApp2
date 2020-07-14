using InvoiceManagementApp2.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp2.Domain.Entities
{
    public class InvoiceItem:AuditingEntity
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public Invoice Invoice { get; set; }
    }
}
