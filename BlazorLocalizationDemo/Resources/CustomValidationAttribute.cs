using Microsoft.Extensions.Localization;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorLocalizationDemo.Resources
{
    //
    // to do: Add Localizations for the error messages
    //
    public class CustomValidationAttribute : ValidationAttribute
    {
        private static readonly Dictionary<ValidationType, Func<object, ValidationContext, CustomValidationAttribute, ValidationResult>> _validationStrategies;

        static CustomValidationAttribute()
        {
            _validationStrategies = new Dictionary<ValidationType, Func<object, ValidationContext, CustomValidationAttribute, ValidationResult>>
            {
                { ValidationType.Required, RequiredValidation},
                { ValidationType.Length, LengthValidation },
            };
        }

        public ValidationType ValidationType { get; }
        public int MinimumLength { get; }
        public int MaximumLength { get; }
        public string Pattern { get; }

        public CustomValidationAttribute(ValidationType validationType, int minimumLength = 0, int maximumLength = 50, string pattern = "")
        {
            ValidationType = validationType;
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
            Pattern = pattern;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult($"The {validationContext.DisplayName} field is required.");
            }

            if (_validationStrategies.TryGetValue(ValidationType, out var validationStrategy))
            {
                return validationStrategy(value, validationContext, this);
            }

            throw new ArgumentOutOfRangeException($"Invalid validation type: {ValidationType}", nameof(ValidationType));
        }

        private static ValidationResult RequiredValidation(object value, ValidationContext validationContext, CustomValidationAttribute attribute)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (validationContext.GetService(typeof(IStringLocalizer<SharedResource>)) is IStringLocalizer<SharedResource> localizer)
                {
                    var localizedFieldName = localizer[validationContext.DisplayName];
                    attribute.ErrorMessage = string.Format(localizer["RequiredError"], localizedFieldName);
                }
                else
                {
                    attribute.ErrorMessage = string.Format("The {0} field is required.", validationContext.DisplayName);
                }
                return new ValidationResult(attribute.ErrorMessage);
            }

            return ValidationResult.Success ?? new ValidationResult("");
        }

        private static ValidationResult LengthValidation(object value, ValidationContext validationContext, CustomValidationAttribute attribute)
        {
            if (value != null)
            {
                var stringValue = value.ToString();
                if (stringValue != null && (stringValue.Length < attribute.MinimumLength || stringValue.Length > attribute.MaximumLength))
                {
                    if (validationContext.GetService(typeof(IStringLocalizer<SharedResource>)) is IStringLocalizer<SharedResource> localizer)
                    {
                        var localizedFieldName = localizer[validationContext.DisplayName];
                        attribute.ErrorMessage = string.Format(localizer["StringLengthError"], localizedFieldName, attribute.MaximumLength, attribute.MinimumLength);
                    }
                    else
                    {
                        attribute.ErrorMessage = $"The {validationContext.DisplayName} field length must be between {attribute.MinimumLength} and {attribute.MaximumLength}.";
                    }
                    return new ValidationResult(attribute.ErrorMessage);
                }
            }

            return ValidationResult.Success ?? new ValidationResult("");
        }
    }

    public enum ValidationType
    {
        Required,
        Length,
    }
}


//how to use it in a model:
//      [Custom_Validation(ValidationType.Length)]
//      [Custom_Validation(ValidationType.Required)]
//      public string MyProperty { get; set; }

