using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Localization;


namespace BlazorLocalizationDemo.Resources
{
   
    public static class DisplayAttributeExtensions
    {
        public static string GetLocalizedName(this DisplayAttribute attribute, IStringLocalizer localizer)
        {
            if (attribute.Name == null)
            {
                // Handle the situation when Name is null.
                // For example, return a default string:
                return "DefaultName";
            }
            return localizer[attribute.Name];
        }
        public static string GetLocalizedName<T>(this IStringLocalizer localizer, string propertyName)
        {
            var displayAttribute = typeof(T).GetProperty(propertyName)?.GetCustomAttributes(typeof(DisplayAttribute), true).FirstOrDefault() as DisplayAttribute;
            return displayAttribute?.Name == null ? propertyName : localizer[displayAttribute.Name];
        }
    }
}
