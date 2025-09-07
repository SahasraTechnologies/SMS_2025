using Microsoft.EntityFrameworkCore;
using SMS.Entities.Models;
using SMS.Services;
using SMS.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Register services in a centralized location

// Register DbContext with the connection string
builder.Services.AddDbContext<SmsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SmsConnection")));

builder.Services.AddScoped<IAppUserService, AppUserService>();



// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure cookie authentication
builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Account/Login"; // Redirect to login page if unauthorized
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/accessdenied";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Set session timeout
        options.SlidingExpiration = true; // Refresh cookie on each request
        options.Cookie.Name = "SMS_2025";
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
