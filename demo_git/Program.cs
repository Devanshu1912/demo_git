var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Home page
app.MapGet("/", () => "Hello Devanshu!");

// Another route (optional)
app.MapGet("/about", () => "This is About Page");

app.Run();