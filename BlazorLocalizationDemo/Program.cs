using BlazorLocalizationDemo.Components;
using BlazorLocalizationDemo.Configuration;
using BlazorLocalizationDemo.Data;
using BlazorLocalizationDemo.Data.Repository;
using BlazorLocalizationDemo.Resources;
using BlazorLocalizationDemo.Services;
using BlazorLocalizationDemo.Services.Localization;
using DeepL;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options => options.DetailedErrors = true
);
builder.Services.AddControllers();

var localizationString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<LocalizationDbContext>(options =>
        options.UseSqlite(localizationString));
builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ILocalizationService, LocalizationService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<IStringLocalizer<SharedResource>, DbStringLocalizer<SharedResource>>();

builder.Services.AddScoped<Translator>(sp =>
{
    var authKey = builder.Configuration["DeepLConfig:AuthKey"] ?? throw new InvalidOperationException("DeepLConfig:AuthKey configuration value not found.");
    return new Translator(authKey);
    
});

builder.Services.AddTransient<SeedLanguage>();

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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

var locOptions = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);

app.UseAntiforgery();

app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

await SeedLanguageAsync(app);

app.Run();

static async Task SeedLanguageAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<LocalizationDbContext>();
    context.Database.EnsureCreated();

    var service = scope.ServiceProvider.GetRequiredService<SeedLanguage>();
    await service.EnsureSeedLanguageAsync();
}
