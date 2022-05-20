using System;
using System.Collections.Generic;

namespace DBFirstTutorial.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Telephone { get; set; }
    }
}
