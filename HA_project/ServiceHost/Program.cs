using Microsoft.EntityFrameworkCore;
using ShopManagemant.Application;
using ShopManagemant.Application.ProductPictureApplication;
using ShopManagemant.Application.SliderApp;
using ShopManagemant.ApplicationContract.Product;
using ShopManagemant.ApplicationContract.ProductCategory;
using ShopManagemant.ApplicationContract.ProductPicture;
using ShopManagemant.ApplicationContract.Slider;
using ShopManagmant.Domin.Product;
using ShopManagmant.Domin.ProductCategory;
using ShopManagmant.Domin.ProductPictureAgg;
using ShopManagmant.Domin.Slid;
using ShopManagtemant.Infrastructure.Reposetory;
using ShopManagtemant.Infrastructure.ShopContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IReposetory, Reposetory>();
builder.Services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
builder.Services.AddTransient<IProductApplication, ProductApplication>();
builder.Services.AddTransient<IProductReposetory, ProductReposetory>();
builder.Services.AddTransient<IProductPicture, ProductPicture>();
builder.Services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
builder.Services.AddTransient<ISliderReposetory, SliderReposetory>();
builder.Services.AddTransient<ISliderApplication, SliderApplication>();





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
