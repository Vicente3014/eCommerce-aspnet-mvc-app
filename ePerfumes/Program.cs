using ePerfumes.Data;
using ePerfumes.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//DbContext Configuration
builder.Services.AddDbContext<AppDBContext>(options=>options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnectionString")));
//Services Confugiration
builder.Services.AddScoped<IMarcasService,MarcaService>();
builder.Services.AddScoped<IPerfumeService,PerfumeService>();
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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=IndexUser}/{id?}");

//Seed Database
App_DB_Initializer.Seed(app);

app.Run();
