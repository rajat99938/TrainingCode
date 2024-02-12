using System.ComponentModel.DataAnnotations;

namespace TestWebApp.ValidationAttributes
{
    public class CustomEmailAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string email = value.ToString();
                // Custom validation logic: check if email ends with "@example.com"
                return email.EndsWith("@example.com", StringComparison.OrdinalIgnoreCase);
            }
            return true; // Return true for null values to allow other validation attributes to handle them
        }
    }
}
