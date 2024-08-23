using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_51_Data_Annotation_Section_51_4
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please provide a name.")]
        [StringLength(20,MinimumLength =5,ErrorMessage = "A name must be between five and twenty\r\ncharacters.")]
        public string Name { get; set; }

        [Range(0.01,100.00, ErrorMessage ="A name must be beween five and twenty character. ")]
        public decimal? Price { get; set; }

        [CustomValidation(typeof(MyCustomeValidation), "IsNotAnApple")]
        public string FavoriteFruit { get; set; }
    }


    public class ImplementContactModel
    {
        public ImplementContactModel()
        {
            try
            {
                ContactModel contact = new ContactModel { 
                Name ="Andreas mangkualam",
                FavoriteFruit = "APPLE"
                };

                ValidationContext vc = new ValidationContext(contact);

                ICollection<ValidationResult> result = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(contact, vc, result, true);
            }
            catch (Exception ex)
            {

            }

        }

    }

    public static class MyCustomeValidation
    {
        public static ValidationResult IsNotAnApple(object input)
        {
            var result = ValidationResult.Success;

            if (input?.ToString()?.ToUpperInvariant() == "APPLE")
            {
                result = new ValidationResult("Apples are not allowed.");
            }

            return result;
        }
    }
}
