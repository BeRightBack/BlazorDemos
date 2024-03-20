using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace BlazorLocalizationDemo.Resources
{
    public class CustomStringLengthAttribute : StringLengthAttribute
    {
        public CustomStringLengthAttribute(int maximumLength) : base(maximumLength)
        {
        }
        public CustomStringLengthAttribute(int minimumLength, int maximumLength) : base(maximumLength)
        {
            MinimumLength = minimumLength;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var stringValue = value.ToString();
                if (stringValue != null && (stringValue.Length < MinimumLength || stringValue.Length > MaximumLength))
                {
                    if (validationContext.GetService(typeof(IStringLocalizer<SharedResource>)) is IStringLocalizer<SharedResource> localizer)
                    {
                        var localizedFieldName = localizer[validationContext.DisplayName];
                        ErrorMessage = string.Format(localizer["StringLengthError"], localizedFieldName, MaximumLength, MinimumLength);
                    }
                    else
                    {
                        ErrorMessage = $"The {validationContext.DisplayName} field length must be between {MinimumLength} and {MaximumLength}.";
                    }
                }
            }

            return base.IsValid(value, validationContext);
        }
    }
}