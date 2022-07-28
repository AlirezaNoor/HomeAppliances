using _0_Framework.GenericReposetory;
using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;

namespace DiscountManegmant.Domin.CustomerDiscountAgg
{
    public interface ICostomerDiscountReposetory:IGenericReposetory<long,CustomerDiscount>
    {
        List<CustomerDiscountViewModel>All();
    }
}
