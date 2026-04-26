using Microsoft.EntityFrameworkCore;
using simulacro.Data;
using simulacro.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MySqlDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MysqlConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MysqlConnection"))));

builder.Services.AddScoped<OwnerService>();
builder.Services.AddScoped<VeterinaryService>();
builder.Services.AddScoped<MedicineService>();


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

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Veterinary}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
