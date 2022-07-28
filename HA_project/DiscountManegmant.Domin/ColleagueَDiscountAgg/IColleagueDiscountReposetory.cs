using _0_Framework.GenericReposetory;
using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using DiscountManegmant.Domin.Colleague_DiscountAgg;

namespace DiscountManegmant.Domin.ColleagueَDiscountAgg
{
    public interface IColleagueDiscountReposetory:IGenericReposetory<long,ColleagueDiscount>
    {
        List<ColleagueDiscountViewModel> all();
    }
}
