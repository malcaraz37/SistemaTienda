using SistemaTienda.Components;
using SistemaTienda.Data;
using SistemaTienda.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.Localization;


var builder = WebApplication.CreateBuilder(args);

// Razor Components (Blazor Server)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Entity Framework Core: conexión a SQL Server
builder.Services.AddDbContext<SistemaTiendaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ?? Registro del repositorio de productos
builder.Services.AddScoped<IRepositorioProductos, RepositorioProductos>();
builder.Services.AddScoped<IRepositorioProveedores, RepositorioProveedores>();
builder.Services.AddScoped<IRepositorioEntradas, RepositorioEntradas>();


var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();



// Routing de componentes
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

var supportedCultures = new[] { new CultureInfo("es-MX") };
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("es-MX"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};

app.UseRequestLocalization(localizationOptions);

app.Run();

