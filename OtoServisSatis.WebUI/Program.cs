
using OtoServisSatis.Data;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.Service.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>();


builder.Services.AddTransient(typeof(IService<>), typeof(Service<>));
builder.Services.AddTransient<ICarService,CarService>();
// bizim yapm�� oldu�umuz servis katman�n� kullana bilmek i�in yapt�k
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/Admin/Login"; // kullan�c�lar nerden login olaca��n� belirttik
    x.AccessDeniedPath= "/AccessDenied"; // yetkisiz eri�imleri y�nlendirdi�imiz yer
    x.LogoutPath = "/Admin/Logout";// ��k��� yapt���m�z adresimiz budur
    x.Cookie.Name = "Admin";
    x.Cookie.MaxAge=TimeSpan.FromDays(7); //cookinin s�resini berlittik
    x.Cookie.IsEssential= true; // bu �erezin �nemli oldu�unu belirtir giri� yaparken bu cookinin �al���yor olmas� zorunludur demek gibi

});


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

app.UseAuthentication(); // bunu authorizaitondan �nce yazmamz gerekmektedir. Login i�lemlerinin �al��mas� i�in buna ihtiyac�m�z var
app.UseAuthorization();

app.MapControllerRoute(
           name: "admin",
           pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
         );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
