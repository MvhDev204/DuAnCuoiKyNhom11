﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DuAnNhom11.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [Required]
        public decimal? ProductPrice { get; set; }
        [StringLength(500)]
        public string? ProductDescription { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
        [StringLength(50)]
        public string? ProductImage { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
    }
}