﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    //Класс создания продуктов
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string? Description { get; set; }
        public long Price { get; set; }
        public int? Availability { get; set; }
        public int SellerId { get; set; }
        public string? Path { get; set; }
        public bool Visibly { get; set; }
        public Category Category { get; set; }
        public bool Moderation { get; set; }
    }
}
