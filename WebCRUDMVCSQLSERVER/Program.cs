using Microsoft.EntityFrameworkCore;
using WebCRUDMVCSQLSERVER.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer
    ("Data Source=D4RK\\;Initial Catalog=CRUD_MVC_SQLSERVER;Integrated Security=True;TrustServerCertificate=True;"));
// <add name="TestDataConnectionString" connectionString="Data Source=.\SQLExpress;Initial Catalog=TestData;User ID=satest;Password=satest"
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
