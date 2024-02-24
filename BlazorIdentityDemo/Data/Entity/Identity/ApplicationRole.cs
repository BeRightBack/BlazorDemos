using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorIdentityDemo.Entity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        [NotMapped]
        public bool Selected { get; set; } = false;

        public string? Description { get; set; }
    }

}
