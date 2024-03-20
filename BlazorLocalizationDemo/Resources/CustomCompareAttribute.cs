using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace BlazorLocalizationDemo.Resources
{
    public class CustomCompareAttribute(string comparisonValue) : ValidationAttribute
    {
        public string ComparisonValue { get; } = comparisonValue;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var stringValue = value!.ToString();
            if (stringValue != ComparisonValue) // Compare against the comparison value
            {
                if (validationContext.GetService(typeof(IStringLocalizer<SharedResource>)) is IStringLocalizer<SharedResource> localizer)
                {
                    var localizedFieldName = localizer[validationContext.DisplayName];
                    var localizedValue = localizer[ComparisonValue];
                    ErrorMessage = string.Format(localizer["CompareError"], localizedFieldName, localizedValue);
                    //return new ValidationResult(ErrorMessage);
                }
                else
                {
                    ErrorMessage = string.Format("The {0} field do not match {1}.", validationContext.DisplayName, ComparisonValue);
                    //ErrorMessage = "The values do not match."; // Update the default error message
                    //return new ValidationResult(ErrorMessage);
                }

                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success!;
        }
    }
}
