using System.Security.AccessControl;

namespace DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract
{
    public class ColleagueDiscountViewModel
    {
        public long id { get; set; }
        public long ProductId { get; set; }
        public string Productname { get; set; }
        public int DiscountRang { get; set; }
        public string createdate { get; set; }

    }
}
