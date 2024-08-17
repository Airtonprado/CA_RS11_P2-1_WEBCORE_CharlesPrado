using CA_RS11_P2_1_WEBCORE_CharlesPrado.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("RSGYMDBContext_Connect");
// TODO ACP: reading connection string de appsettings.json

//TODO ACP: register the service in EF, Add DbContext with SQL Server or SQLite
builder.Services.AddDbContext<RSGYMDBContext_Connect>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RSGYMDBContext_Connect"))
// options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")) // For SQLite
);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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