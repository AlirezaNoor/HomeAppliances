using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.AdminiStrator.Models.ColleagueDiscount
{
    public class ColleagueDiscountModels
    {
        public CreateColleagueDiscount create { get; set; }
        public Edited Edited { get; set; }

        public SelectList list { get; set; }
        public List<ColleagueDiscountViewModel> All { get; set; }
    }
}
