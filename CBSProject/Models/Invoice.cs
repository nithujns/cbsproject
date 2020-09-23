using System;

namespace CBSProject.Models
{
    public class Invoice
    {
        public long InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime  DueDate { get; set; }
        public int Total { get; set; }
        public int AmountDue{ get; set; }
        public string Terms { get; set; }
        public string Description { get; set; }
        public long PONumber{ get; set; }
    }
}
