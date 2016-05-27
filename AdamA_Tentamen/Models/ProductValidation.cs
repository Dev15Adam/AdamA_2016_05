using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamA_Tentamen.Models
{
    public class ProductValidation : ValidationAttribute
    {
        protected bool IsValid(Product value)
        {
            if (value == null)
            {
                return false;
            }
            var ToCheck = ToString().ToLower();
            return ToCheck.StartsWith("p");

        }

        public override string FormatErrorMessage(string field)
        {
            return field + "Must start with p then digets";
        }
    }
}
