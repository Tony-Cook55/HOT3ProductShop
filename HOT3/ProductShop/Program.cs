using ProductShop.Models;

using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);


// Makes everything in the url lowercase and adds a / to the end of the url
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});


// Add services to the container.
builder.Services.AddControllersWithViews();


// Add these to allow Server Side Sessions to store States in
builder.Services.AddMemoryCache();
builder.Services.AddSession();




// Add a database context
builder.Services.AddDbContext<RecordContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RecordShopConnectionString")));




var app = builder.Build();



// Enables the Sessions on the Server
app.UseSession();



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

app.UseAuthorization();



app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}"
);



app.Run();
