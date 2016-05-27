using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamA_Tentamen.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required, Range(1,25)]
        public string Name { get; set; }
        public string ProductText { get; set; }
        [Required]
        [ProductValidation]
        public string ProductNumber { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool ProductInStock { get; set; }
    }
}
