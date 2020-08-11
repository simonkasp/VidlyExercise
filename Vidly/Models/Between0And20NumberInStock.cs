using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Vidly.Models
{
    public class Between0And20NumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock == 0)
                return new ValidationResult("Number in Stock is required.");

            return (movie.NumberInStock > 20 || movie.NumberInStock < 0) ? new ValidationResult("Number in Stock must be between 0 and 20") : ValidationResult.Success;
        }
    }
}