// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public partial class OrderItems
    {
        public int ItemsId { get; set; }
        public int? OrderId { get; set; }
        public int? MenuId { get; set; }
        public int? Quantity { get; set; }
        public bool? IsCompleted { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual ResOrder Order { get; set; }
    }
}