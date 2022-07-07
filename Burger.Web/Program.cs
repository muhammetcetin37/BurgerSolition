using Burger.BL.Abstract;
using Burger.BL.Concrete;
using Burger.DAL.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services
    .AddDbContext<SqlDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Burger")));

builder.Services.AddScoped<IKategoriManager, KategoriManager>();
builder.Services.AddScoped<IUserManager, UserManager>();
#region Cookie Ayarlari
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/User/Login";
                    options.LogoutPath = "/User/Logout";
                    options.AccessDeniedPath = "/User/Yasak";
                    options.Cookie.Name = "ErcanBurger";
                    options.Cookie.HttpOnly = true;//Güvenlikler ilgili,Tarayıcımızdaki diger scriptler okuyamasın.
                    options.Cookie.SameSite = SameSiteMode.Strict;//Güvenlik ile ilgili.Bizim tarayicimiz disinda okunamasın.
                });
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});


app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();