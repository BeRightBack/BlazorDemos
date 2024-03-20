using BlazorLocalizationDemo.Resources;
using System.ComponentModel.DataAnnotations;
using CustomValidationAttribute = BlazorLocalizationDemo.Resources.CustomValidationAttribute;

namespace BlazorLocalizationDemo.Models
{
    public class Person
    {
        
        [Display(Name = "Name")]
        [CustomRequired]
        public string? Name { get; set; }
        
        [CustomRequired]
        [Display(Name = "UserName")]
        public string? UserName { get; set; }

        [CustomRequired]
        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [CustomRequired]
        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        [CustomRequired]
        [CustomEmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [CustomRequired]
        [CustomStringLength(6, 100)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = "";

        [CustomRequired]
        [CustomStringLength(6, 100)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [CustomCompare("Password")]
        public string ConfirmPassword { get; set; } = "";

    
    }
}


