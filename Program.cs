var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

/* ROUTE TRANG CHỦ */
app.MapControllerRoute(
    name: "home",
    pattern: "",
    defaults: new { controller = "Student", action = "Index" }
);

/* ROUTE MVC BÌNH THƯỜNG */
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Student", action = "Index" }
);

app.Run();
