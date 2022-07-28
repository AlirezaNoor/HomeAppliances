using _0_Framework.Application;

namespace DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract
{
    public interface IColleagueDiscountApplication
    {
        OperationResult create(CreateColleagueDiscount command);
        OperationResult Edited(Edited command);
        Edited dtails(long id);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        List<ColleagueDiscountViewModel> all();

    }
}
