var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<MyRazorApp.Pages.service.ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.Use(async (context, next) =>
 {
     var requestPath = context.Request.Path.Value;

     // Prevent access to sensitive config and json files
     if (requestPath.EndsWith(".config") || requestPath.EndsWith(".json"))
     {
         context.Response.StatusCode = 403; // Forbidden
         await context.Response.WriteAsync("Access to this file type is restricted.");
     }
     // Check for directory traversal
     else if (requestPath.Contains(".."))
     {
         context.Response.StatusCode = 400; // Bad Request
         await context.Response.WriteAsync("Invalid request path.");
     }
     else
     {
         await next();
     }
 });


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
