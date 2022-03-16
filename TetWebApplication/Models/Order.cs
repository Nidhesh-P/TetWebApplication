﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TetWebApplication.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}