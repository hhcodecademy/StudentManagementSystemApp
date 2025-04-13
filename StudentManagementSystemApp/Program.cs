using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Data;
using StudentManagementSystemApp.Profiles;
using StudentManagementSystemApp.Repositories;
using StudentManagementSystemApp.Repositories.Interfaces;
using StudentManagementSystemApp.Services;
using StudentManagementSystemApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(
    builder.Configuration.GetConnectionString("SqlServerConnStr")
));

builder.Services.AddAutoMapper(typeof(CustomProfile));

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseService,CourseService>();

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
