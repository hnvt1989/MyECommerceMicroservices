﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyECommerceMicroservices.Models.ShoppingCart
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool Active { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        [ForeignKey("Product")]
        public virtual ICollection<Product> Products { get; set; } 

        public byte[] Icon { get; set; }

        public int ParentId { get; set; }
    }
    
}