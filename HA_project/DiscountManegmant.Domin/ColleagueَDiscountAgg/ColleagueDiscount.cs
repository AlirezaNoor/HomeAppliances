using _0_Framework;

namespace DiscountManegmant.Domin.Colleague_DiscountAgg
{
    public class ColleagueDiscount:Golbaldomin
    {
        public int DiscountRange { get; private set; }
        public long ProductId { get; private set; }
        public bool IsRemove { get; private set; }

        public ColleagueDiscount(int discountRange, long productId)
        {
            DiscountRange = discountRange;
            ProductId = productId;
        
            IsRemove = false;
        }
       public void Edited(int discountRange, long productId)
        {
            DiscountRange = discountRange;
            ProductId = productId;
        }

       public void Remove()
       {
           IsRemove=true;
       }
       public void Restor()
       {
           IsRemove = false;
       }
    }
}
