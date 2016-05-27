using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamA_Tentamen.Models
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        [Required, Range(1,25)]
        public string Name { get; set; }
        [Required, Range(1,35)]
        public string Adress { get; set; }
        public List<Product> Products { get; set; }
    }
}
