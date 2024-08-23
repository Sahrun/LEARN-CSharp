using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_51_Data_Annotation_Section_51_2
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class NotABananaAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var inputValue = value as string;
            var isValid = true;

            if (!string.IsNullOrEmpty(inputValue))
            {
                isValid = inputValue.ToUpperInvariant() != "BANANA";

            }
            return isValid;

        }
    }


    public class Model
    {
        [NotABanana(ErrorMessage = "Bananas are not allowed.")]
        public string FavoriteFruit { get; set; }
    }

    public class ImplementModel
    {
        public ImplementModel()
        {
            try
            {
                var model = new Model();
                model.FavoriteFruit = "BANANA";

                var context = new ValidationContext(model, serviceProvider: null, items: null);
                var validationResults = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);

                if (!isValid)
                {
                    foreach (var validationResult in validationResults)

                    {
                        Console.WriteLine(validationResult.ErrorMessage);
                    }
                }
                else {
                    Console.WriteLine("Model is valid!");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
