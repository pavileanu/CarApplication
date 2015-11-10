using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarApplication
{
      public class CheckDateRangeAttribute : ValidationAttribute
      {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
               DateTime dt = (DateTime)value;
                if (dt <= DateTime.UtcNow)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Make sure your date is set before today");
            }

     }
}