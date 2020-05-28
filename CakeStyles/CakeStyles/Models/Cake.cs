using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CakeStyles.Models
{
    public class Cake
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Price/kg")]
        public decimal Price { get; set; }
    }
}
