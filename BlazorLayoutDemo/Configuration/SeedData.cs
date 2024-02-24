using System.Security.Claims;
using BlazorLayoutDemo.Data;
using BlazorLayoutDemo.Entity;
using Microsoft.AspNetCore.Identity;

namespace BlazorLayoutDemo.Configuration;


public class SeedData
{

    private static ApplicationDbContext? _context;
    private static UserManager<ApplicationUser>? _userManager;
    private static IUserStore<ApplicationUser>? _userStore;
    private static RoleManager<ApplicationRole>? _roleManager;


    public SeedData(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore, RoleManager<ApplicationRole> roleManager)
    {
        _context = context;
        _userManager = userManager;
        _userStore = userStore;
        _roleManager = roleManager;
    }
    public async static Task EnsureSeedDataAsync()
    {

        if (_context?.Database == null)
        {
            throw new Exception("DB is null");
        }

        if (!_context.Roles.Any())
        {
            var member = _roleManager?.FindByNameAsync("User").Result;
            var admin = _roleManager?.FindByNameAsync("Administrator").Result;



            if (member == null)
            {
                member = new ApplicationRole
                {
                    Name = "User",
                    Description = "User Role"
                };
                _ = _roleManager?.CreateAsync(member).Result;
            }


            if (admin == null)
            {
                admin = new ApplicationRole
                {
                    Name = "Administrator",
                    Description = "Administrator Role"
                };
                _ = _roleManager?.CreateAsync(admin).Result;
            }


            if (!_context.Users.Any())
            {


                var _user = _userManager?.FindByNameAsync("RegularUser").Result;
                if (_user == null)
                {
                    _user = new ApplicationUser
                    {
                        UserName = "RegularUser",
                        Email = "alice_smith@example.com",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        FirstName = "Alice",
                        LastName = "Smith",
                        PhoneNumber = "1234567890",
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        AccessFailedCount = 0,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        ProfilePicturePath = "https://frenzyzone.com/Images/user-icon.jpg"
                    };
                    await _userStore!.SetUserNameAsync(_user, _user.UserName, CancellationToken.None);
                    var emailStore = GetEmailStore();
                    await emailStore.SetEmailAsync(_user, _user.Email, CancellationToken.None);
                    var result = await _userManager!.CreateAsync(_user, "Abc@123");


                    await _context.SaveChangesAsync();
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }

                    result = _userManager.AddClaimsAsync(_user, new Claim[]{
                       new Claim("user.username","RegularUser"),
                       new Claim("user.firstname","Alice"),
                       new Claim("user.lastname","Smith"),
                       new Claim("user.fullname", "Alice Smith"),
                       new Claim("user.email","alice_smith@example.com"),
                       new Claim("user.picture","Images/user-icon.jpg"),
                       new Claim("user.role","User"),
                       new Claim("user.website","https://example.com")
                    }).Result;

                    if (!_userManager.IsInRoleAsync(_user, member.Name!).Result)
                    {
                        _ = _userManager.AddToRoleAsync(_user, member.Name!).Result;
                    }

                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    //Log.Debug("user created");
                }
                else
                {
                    //Log.Debug("user already exists");
                }

                var user = _userManager?.FindByNameAsync("Administrator").Result;
                if (user == null)
                {
                    user = new ApplicationUser
                    {
                        UserName = "Administrator",
                        Email = "admin@example.com",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        FirstName = "Admin",
                        LastName = "Admin",
                        PhoneNumber = "1234567890",
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        AccessFailedCount = 0,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        ProfilePicturePath = "https://example.com/Images/user-icon.jpg"
                    };

                    await _userStore!.SetUserNameAsync(user, user.UserName, CancellationToken.None);
                    var emailStore = GetEmailStore();
                    await emailStore.SetEmailAsync(user, user.Email, CancellationToken.None);
                    var result = await _userManager!.CreateAsync(user, "Abc@123");

                    await _context.SaveChangesAsync();
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }

                    result = _userManager.AddClaimsAsync(user, new Claim[]{
                       new Claim("user.username","Administrator"),
                       new Claim("user.firstname","John"),
                       new Claim("user.lastname","Smith"),
                       new Claim("user.fullname", "John Smith"),
                       new Claim("user.email","admin@example.com"),
                       new Claim("user.picture","Images/user-icon.jpg"),
                       new Claim("user.role","User"),
                       new Claim("user.role","Administrator"),
                       new Claim("user.website","https://example.com")
                    }).Result;

                    if (!_userManager.IsInRoleAsync(user, admin.Name!).Result)
                    {
                        _ = _userManager.AddToRoleAsync(user, admin.Name!).Result;
                    }


                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    //Log.Debug("user created");
                }
                else
                {
                    //Log.Debug("user already exists");
                }
            }

        }

        return;


    }

    private ApplicationUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<ApplicationUser>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor.");
        }
    }

    private static IUserEmailStore<ApplicationUser> GetEmailStore()
    {
        if (!_userManager!.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<ApplicationUser>)_userStore!;
    }

}



