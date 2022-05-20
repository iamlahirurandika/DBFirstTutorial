﻿using System;
using System.Collections.Generic;

namespace DBFirstTutorial.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Uom { get; set; } = null!;
        public decimal? Price { get; set; }
        public string? Stock { get; set; }
    }
}
