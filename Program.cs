using HotelSchema_Lab12.Data;
using Microsoft.EntityFrameworkCore;
using HotelSchema_Lab12.Models.Interfaces;
using HotelSchema_Lab12.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TestDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AzureContext")));
builder.Services.AddTransient<IHotel, HotelService>();
builder.Services.AddTransient<IRoom, RoomsService>();
builder.Services.AddTransient<IAmenity, AmenityService>();
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