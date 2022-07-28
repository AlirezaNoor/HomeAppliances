using _0_Framework.Application;
using _0_Framework.Infrastructure;
using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using DiscountManegmant.Domin.Colleague_DiscountAgg;
using DiscountManegmant.Domin.ColleagueَDiscountAgg;
using DiscountManegmant.Infrastructure.context;
using Microsoft.EntityFrameworkCore;
using ShopManagtemant.Infrastructure.ShopContext;

namespace DiscountManegmant.Infrastructure.Reposetory
{
    public class ColleagueDiscountReposetory:GenericReposetory<long,ColleagueDiscount>,IColleagueDiscountReposetory
    {

        private readonly CustomerDiscountContext _customercontext;
        private readonly MyContext _shopContext;

        public ColleagueDiscountReposetory(CustomerDiscountContext context, MyContext shopContext) : base(context)
        {
            _customercontext = context;
            this._shopContext = shopContext;
        }

        public List<ColleagueDiscountViewModel> all()
        {
            var query = _customercontext.colleague.Select(x => new ColleagueDiscountViewModel()
            {
                DiscountRang = x.DiscountRange,
                ProductId = x.ProductId,
                createdate = x.datetime.ToFarsi(),
                id = x.Id,

            }).ToList();
            var product = _shopContext.prioduct.Select(x => new {id = x.Id, name = x.Name}).ToList();
            var discount = query.OrderByDescending(x => x.id).ToList();
            discount.ForEach(x=>x.Productname=product.FirstOrDefault(y=>y.id==x.ProductId)?.name);
            return discount;
        }
    }
}
