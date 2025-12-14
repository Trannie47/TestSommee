routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
);
