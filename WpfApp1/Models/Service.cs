﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    //Клас создания услуг
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public long Price { get; set; }
        public int SellerId { get; set; }
        public bool Visibly { get; set; } 
        public int? CategoryId { get; set; }
        public bool Moderation { get; set; }    
        public Category category { get; set; }
    }
}
