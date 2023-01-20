using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EventVerse.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using EventVerse.Application.Interfaces.Services;
using EventVerse.Infrastructure.Services;
using EventVerse.Infrastructure.Persistence;
using EventVerse.Core.Entities;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EventVerseContextConnection") ?? throw new InvalidOperationException("Connection string 'EventVerseContextConnection' not found.");

builder.Services.AddDbContext<EventVerseContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<EventVerseContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IFileService, FileService>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailSender, EmailSenderCustom>();
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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
