using _01_Query.Slider.Conteracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagtemant.Infrastructure.ShopContext;

namespace _01_Query.Slider.Query
{
    public class SliderQuery:ISliderQuery
    {
        private readonly MyContext _context;

        public SliderQuery(MyContext context)
        {
            _context = context;
        }

        public List<SliderQueryModel> GetAll()
        {
            return _context.Slider.Select(x => new SliderQueryModel()
            {
                title = x.title,
                headingTitle = x.headingTitle,
                Btntitle = x.Btntitle,
                Link = x.Link,
                discription = x.discription,
                slidePicture = x.slidePicture
            }).ToList();
        }
    }
}
