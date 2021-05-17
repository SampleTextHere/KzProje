﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public double Views { get; set; }
        public float NoDiscount { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
