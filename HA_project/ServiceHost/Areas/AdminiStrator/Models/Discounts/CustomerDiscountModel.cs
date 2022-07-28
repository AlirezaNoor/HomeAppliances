using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.AdminiStrator.Models.Discounts
{
    public class CustomerDiscountModel
    {
        public SelectList SelectList { get; set; }
        public CreateCustomerDiscount CreateCustomerDiscount { get; set; }
        public List<CustomerDiscountViewModel> List { get; set; }
    }
}
