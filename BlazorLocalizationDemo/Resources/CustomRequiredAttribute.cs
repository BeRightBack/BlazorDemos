using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace BlazorLocalizationDemo.Resources
{
    public class CustomRequiredAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (validationContext.GetService(typeof(IStringLocalizer<SharedResource>)) is IStringLocalizer<SharedResource> localizer)
                {
                    var localizedFieldName = localizer[validationContext.DisplayName];
                    ErrorMessage = string.Format(localizer["RequiredError"], localizedFieldName);
                }
                else
                {
                    ErrorMessage = string.Format("The {0} field is required.", validationContext.DisplayName);
                }
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
