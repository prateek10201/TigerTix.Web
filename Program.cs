var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.MapGet("/", () => "Hello World!"); 
app.UseDefaultFiles();
app.UseStaticFiles();


app.Run();
