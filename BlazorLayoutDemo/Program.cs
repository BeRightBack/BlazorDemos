using BlazorLayoutDemo.Components;
using BlazorLayoutDemo.Components.Account;
using BlazorLayoutDemo.Configuration;
using BlazorLayoutDemo.Data;
using BlazorLayoutDemo.Entity;
using BlazorLayoutDemo.Repository;
using BlazorLayoutDemo.Services;
using DeepL;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Resources;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddControllers();


builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'Layout1Connection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

var localizationString = builder.Configuration.GetConnectionString("LocalizationConnection") ?? throw new InvalidOperationException("Connection string 'Layout2Connection' not found.");
builder.Services.AddDbContext<LocalizationDbContext>(options =>
        options.UseSqlite(localizationString));

var catalogString = builder.Configuration.GetConnectionString("CatalogConnection") ?? throw new InvalidOperationException("Connection string 'Layout3Connection' not found.");
builder.Services.AddDbContext<CatalogDbContext>(options =>
        options.UseSqlite(catalogString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequiredUniqueChars = 6;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = true;
})
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<BlazorLayoutDemo.Services.IEmailSender<ApplicationUser>, EmailSender>();

builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ILocalizationService, LocalizationService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<IStringLocalizer<SharedResource>, DbStringLocalizer<SharedResource>>();
builder.Services.AddScoped<Translator>(sp =>
{
    var authKey = builder.Configuration["DeepLConfig:AuthKey"];
    if (authKey == null)
    {
        throw new ArgumentNullException(nameof(authKey));
    }

    return new Translator(authKey);
});
builder.Services.AddScoped<BookService>();
builder.Services.AddTransient<SeedData>();
builder.Services.AddTransient<SeedLanguage>();
//builder.Services.AddTransient<SeedProducts>();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new List<CultureInfo>
                {
                new("en"),
                new("fr"),
                new("es"),
                new("it"),
                new("pt")
                };

    options.DefaultRequestCulture = new RequestCulture(culture: "fr", uiCulture: "fr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();


var locOptions = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

await SeedDatabaseAsync(app);
await SeedLanguageAsync(app);
//await SeedProductsAsync(app);

app.Run();

//Seed Data
static async Task SeedDatabaseAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.EnsureCreated();

    var service = scope.ServiceProvider.GetRequiredService<SeedData>();
    await SeedData.EnsureSeedDataAsync();
}
static async Task SeedLanguageAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<LocalizationDbContext>();
    context.Database.EnsureCreated();

    var service = scope.ServiceProvider.GetRequiredService<SeedLanguage>();
    await service.EnsureSeedLanguageAsync();
}

//Seed Products
//static async Task SeedProductsAsync(WebApplication app)
//{
//    using var scope = app.Services.CreateScope();
//    var context = scope.ServiceProvider.GetRequiredService<CatalogDbContext>();
//    context.Database.EnsureCreated();

//    var service = scope.ServiceProvider.GetRequiredService<SeedProducts>();
//    await SeedProducts.EnsureSeedDataAsync();
//}


