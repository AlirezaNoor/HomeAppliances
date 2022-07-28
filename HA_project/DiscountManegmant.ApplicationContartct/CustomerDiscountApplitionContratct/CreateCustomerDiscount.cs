namespace DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct
{
    public class CreateCustomerDiscount
    {
        public long productId { get; set; }
        public int DiscountRate { get; set; }
        public string StartDiscount { get; set; }
        public string EndDiscount { get; set; }
        public string Reason { get; set; }

    }
}
