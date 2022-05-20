using System;
using System.Collections.Generic;

namespace DBFirstTutorial.Models
{
    public partial class InvoiceLine
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public string? ItemCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? LineTotal { get; set; }
    }
}
