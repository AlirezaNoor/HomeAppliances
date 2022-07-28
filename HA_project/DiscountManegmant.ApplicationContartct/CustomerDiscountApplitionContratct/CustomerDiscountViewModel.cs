namespace DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;

public class CustomerDiscountViewModel
{
    public long id { get; set; }
    public long productId { get; set; }
    public string productname { get; set; }
    public int DiscountRate { get; set; }
    public string StartDiscount { get; set; }
    public DateTime StartDiscountEn { get; set; }

    public string EndDiscount { get; set; }
    public DateTime EndDiscountEn { get; set; }

    public string Reason { get; set; }
}