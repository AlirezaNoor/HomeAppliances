using _0_Framework;

namespace DiscountManegmant.Domin.CustomerDiscountAgg
{
    public class CustomerDiscount:Golbaldomin
    {
        public long productId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime StartDiscount { get; private set; }
        public DateTime EndDiscount { get; private set; }
        public string Reason { get; private set; }

        public CustomerDiscount(long productId, int discountRate, DateTime startDiscount, DateTime endDiscount, string reason)
        {
            this.productId = productId;
            DiscountRate = discountRate;
            StartDiscount = startDiscount;
            EndDiscount = endDiscount;
            Reason = reason;
        }

        public void Edit(long productId, int discountRate, DateTime startDiscount, DateTime endDiscount, string reason)
        {
            this.productId = productId;
            DiscountRate = discountRate;
            StartDiscount = startDiscount;
            EndDiscount = endDiscount;
            Reason = reason;
        }

    }
}
