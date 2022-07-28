using _01_Query.Productcategory.Contracts;
using _01_Query.Productcategory.Contracts.ProductWithProductcategory;
using _01_Query.Productcategory.Query;
using _01_Query.Slider.Conteracts;
using _01_Query.Slider.Query;
using DiscountManegmant.Application.ColleagueAppcontract;
using DiscountManegmant.Application.CustomerDiscountApplication;
using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;
using DiscountManegmant.Domin.ColleagueóDiscountAgg;
using DiscountManegmant.Domin.CustomerDiscountAgg;
using DiscountManegmant.Infrastructure.context;
using DiscountManegmant.Infrastructure.Reposetory;
using Domin.Inventory.InventoryAgg;
using Inventory.Application.Inventory;
using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.Reposetory;
using InventoryMangament.Applictioncontract.inventory;
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
using ProductCategoryQueryModel = _01_Query.Productcategory.Query.ProductCategoryQueryModel;

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
builder.Services.AddTransient<ISliderQuery, SliderQuery>();
builder.Services.AddTransient<IproductCategoryQueryModel, ProductCategoryQueryModel>();
builder.Services.AddTransient<ICustomerDiscountApplication, CustomerDiscountApplication>();
builder.Services.AddTransient<ICostomerDiscountReposetory, CustomerDiscountReposetory>();
builder.Services.AddTransient<IColleagueDiscountReposetory, ColleagueDiscountReposetory>();
builder.Services.AddTransient<IColleagueDiscountApplication, ColleagueDiscountApplication>();
builder.Services.AddTransient<IInventoryApplication, InventoryApplicartion>();
builder.Services.AddTransient<IInventoryReposetory, InventoryReposetory>();
builder.Services.AddTransient<IProductQuery, ProductQuery>();








var conectionstring = builder.Configuration.GetConnectionString("Application");
builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(conectionstring));
builder.Services.AddDbContext<CustomerDiscountContext>(x => x.UseSqlServer(conectionstring));
builder.Services.AddDbContext<InventoryContext>(x => x.UseSqlServer(conectionstring));


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
