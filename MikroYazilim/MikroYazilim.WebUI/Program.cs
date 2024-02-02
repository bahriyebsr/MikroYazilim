using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MikroYazilim.Business.Manager;
using MikroYazilim.Business.Services;
using MikroYazilim.Data.Context;
using MikroYazilim.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MikroYazilimContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped(typeof(IRepository<>), typeof(SqlRepository<>));
builder.Services.AddScoped<IUserService,UserManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
	options.LoginPath = new PathString("/");
	options.LogoutPath = new PathString("/");
	options.AccessDeniedPath = new PathString("/");

});
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{Controller=Dashboard}/{Action=Index}/{id?}"
	);
app.MapDefaultControllerRoute();


app.Run();
