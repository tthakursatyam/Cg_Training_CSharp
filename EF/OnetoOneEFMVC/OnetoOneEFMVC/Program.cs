using Microsoft.EntityFrameworkCore;
using OnetoOneEFMVC.Data;
using OnetoOneEFMVC.Models;
using OnetoOneEFMVC.Repository;
using OnetoOneEFMVC.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddDbContext<StudentManagementContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
