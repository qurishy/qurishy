﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }


        public Order Order { get; set; }

        public Books Books { get; set; }


    }
}
