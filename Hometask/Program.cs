using Hometask.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationsDbContext>(opt =>
{
    opt.UseSqlServer("Server= DESKTOP-DCPM49P\\SQLEXPRESS;Database= RelationsTask;Integrated Security =True");
});
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
