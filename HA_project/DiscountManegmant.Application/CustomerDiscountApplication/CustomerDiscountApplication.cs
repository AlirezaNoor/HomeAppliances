using _0_Framework.Application;
using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;
using DiscountManegmant.Domin.CustomerDiscountAgg;

namespace DiscountManegmant.Application.CustomerDiscountApplication
{
    public class CustomerDiscountApplication:ICustomerDiscountApplication
    {
        private readonly ICostomerDiscountReposetory _reposetory;

        public CustomerDiscountApplication(ICostomerDiscountReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult Create(CreateCustomerDiscount command)
        {
            var oertion = new OperationResult();
            var strat = command.StartDiscount.ToGeorgianDateTime();
            var End = command.EndDiscount.ToGeorgianDateTime();

            var create = new CustomerDiscount(command.productId, command.DiscountRate, strat,
                End, command.Reason);
            _reposetory.Create(create);
            _reposetory.Save();
            return oertion.Secusees();

        }
          
        public OperationResult EditCustomerDiscounts(EditCustomerDiscount command)
        {
            var oertion = new OperationResult();
            var strat = command.StartDiscount.ToGeorgianDateTime();
            var End = command.EndDiscount.ToGeorgianDateTime();

            var Discount = _reposetory.GetById(command.id);
            Discount.Edit(command.productId,command.DiscountRate,strat,End,command.Reason);
            _reposetory.Save();
            return oertion.Secusees();

        }

        public EditCustomerDiscount Details(long id)
        {
            var x = _reposetory.GetById(id);

            return new EditCustomerDiscount()
            {
                DiscountRate = x.DiscountRate,
                EndDiscount = x.StartDiscount.ToFarsi(),
                StartDiscount = x.StartDiscount.ToFarsi(),
                Reason = x.Reason,
                id = x.Id,
                productId = x.productId,

            };
        }

        public List<CustomerDiscountViewModel> GetAll()

        {
            return _reposetory.All();
        }
    }
}
