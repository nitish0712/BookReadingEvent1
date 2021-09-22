
using System.ComponentModel.DataAnnotations;
using Common;
using System.Collections.Generic;
using BusinessLayer;
using System.Linq;
namespace BookReading.Validation
    {
    public class UserEmailValidator:ValidationAttribute
        {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
            IEnumerable<User> users = new AllUsers1().GetUsers;
            var property1 = validationContext.ObjectType.GetProperty("UserName");
            var property2= validationContext.ObjectType.GetProperty("EmailId");
            string userName = (string)property1.GetValue(validationContext.ObjectInstance);
            string emailId=(string)property2.GetValue(validationContext.ObjectInstance);
            
            var queryEmailId = (from u in users
                               where u.EmailId.Equals(emailId,System.StringComparison.OrdinalIgnoreCase)
                               select u).ToList().Count;


            if (queryEmailId==0)
                {
                
                    return ValidationResult.Success;
                }
            else
                return new ValidationResult("" + validationContext.DisplayName + " already exists");

            }
        }
    }