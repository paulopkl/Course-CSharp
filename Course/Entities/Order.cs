﻿using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString()
        {
            return $"{this.Id}, {this.Moment}, {this.status}";
        }
    }
}
