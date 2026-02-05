using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagerApp.Data;

var builder = WebApplication.CreateBuilder(args);

// --------------------
// Database
// --------------------
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// --------------------
// Identity
// --------------------
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>();

// --------------------
// Razor Pages
// --------------------
builder.Services.AddRazorPages();

var app = builder.Build();

// --------------------
// Middleware
// --------------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// --------------------
// Endpoints
// --------------------
app.MapRazorPages();

app.Run();
