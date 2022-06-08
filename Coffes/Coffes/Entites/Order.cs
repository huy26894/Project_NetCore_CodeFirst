﻿using System;
using System.Collections.Generic;

namespace Coffes.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
