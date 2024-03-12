using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<TigerTixContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/App/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!"); 
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}");


app.Run();
