using _0_Framework.Application;

namespace DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Create(CreateCustomerDiscount command);
        OperationResult EditCustomerDiscounts(EditCustomerDiscount command);
        EditCustomerDiscount Details(long id);
        List<CustomerDiscountViewModel> GetAll();
    }
}
