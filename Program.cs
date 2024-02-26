var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

//1.Yol: 
//{controller=Home}/{action=Index}/id? şemasını oluşturuyor.
//app.MapDefaultControllerRoute();

//2.Yol:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
