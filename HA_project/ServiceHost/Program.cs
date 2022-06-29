using Microsoft.EntityFrameworkCore;
using ShopManagemant.Application;
using ShopManagemant.ApplicationContract.ProductCategory;
using ShopManagmant.Domin.ProductCategory;
using ShopManagtemant.Infrastructure;
using ShopManagtemant.Infrastructure.ShopContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IReposetory, Reposetory>();
builder.Services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
var conectionstring = builder.Configuration.GetConnectionString("Application");
builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(conectionstring));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
