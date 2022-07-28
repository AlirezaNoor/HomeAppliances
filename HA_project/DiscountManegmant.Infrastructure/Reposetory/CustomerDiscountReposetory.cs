using _0_Framework.Application;
using _0_Framework.Infrastructure;
using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;
using DiscountManegmant.Domin.CustomerDiscountAgg;
using DiscountManegmant.Infrastructure.context;
using Microsoft.EntityFrameworkCore;
using ShopManagtemant.Infrastructure.ShopContext;

namespace DiscountManegmant.Infrastructure.Reposetory
{
    public class CustomerDiscountReposetory:GenericReposetory<long,CustomerDiscount>,ICostomerDiscountReposetory
    {
        private readonly CustomerDiscountContext _customercontext;
        private readonly MyContext _shopContext;

        public CustomerDiscountReposetory(CustomerDiscountContext context, MyContext shopContext) : base(context)
        {
            _customercontext = context;
            this._shopContext = shopContext;
        }

        public List<CustomerDiscountViewModel> All()
        {
            var query = _customercontext.Customer.Select(x=>new CustomerDiscountViewModel()
            {
                DiscountRate = x.DiscountRate,
                EndDiscount = x.EndDiscount.ToFarsi(),
                EndDiscountEn = x.EndDiscount,
                Reason = x.Reason,
                StartDiscount = x.StartDiscount.ToFarsi(),
                StartDiscountEn = x.EndDiscount,
                id = x.Id,
                productId = x.productId,
                }).ToList();
            var product = _shopContext.prioduct.Select(x => new {x.Id, x.Name}).ToList();
            var discount = query.OrderByDescending(x => x.id).ToList();
          discount.ForEach(x=>x.productname=product.FirstOrDefault(y=>y.Id==x.productId)?.Name);

          return discount;
        }
    }
}
