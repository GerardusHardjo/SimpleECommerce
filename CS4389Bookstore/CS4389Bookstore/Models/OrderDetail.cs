﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4389Bookstore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Book Album { get; set; }
        public virtual Order Order { get; set; }
    }
}