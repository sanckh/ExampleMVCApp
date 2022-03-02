using Microsoft.EntityFrameworkCore;
using Infrastructure.Repository;
using Infrastructure.Services;
using Infrastructure.Data;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddDbContextFactory<DbContext, EmployeeContextDB>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDb"));
});



builder.Services.AddScoped<IEmployeeService, EmployeeService>();


builder.Services.AddScoped<IEmployee, EmployeeRepository>();


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
