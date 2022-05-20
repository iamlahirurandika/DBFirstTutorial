using System;
using System.Collections.Generic;

namespace DBFirstTutorial.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string CustCode { get; set; } = null!;
        public decimal? LineTotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Total { get; set; }
    }
}
