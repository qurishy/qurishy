﻿using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int BookId{ get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public double UnitPrice { get; set; }


        public Books Book { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

     


        
    }
}
