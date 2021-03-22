using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Product
    {
        
        public int productId { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
      
        public string productName { get; set; }
        [Required(ErrorMessage = "Please enter a product price.")]
        public double productPrice { get; set; }

        public DateTime DateAdded { get; set; }

        public string Slug => productName?.Replace(' ', '-').ToLower()+ '-' + productId.ToString() ;
        
    }
}
