using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebClient.Context;
using WebClient.Extensions;
using WebClient.Repositories.Concrete;
using WebClient.Repositories.Interfaces;
using WebClient.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.DbContextConfig(builder.Configuration); 
builder.Services.IdentityConfig();
builder.Services.ServiceRegisteration();
// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.ConfigureDefaultAdminUser();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
    );
    endpoints.MapAreaControllerRoute(
        name: "User",
        areaName: "User",
        pattern: "User/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute("default", "{controller=Account}/{action=Login}/{id?}");

});

app.Run();
