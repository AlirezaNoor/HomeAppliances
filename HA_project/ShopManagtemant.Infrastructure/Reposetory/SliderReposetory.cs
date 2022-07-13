using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagmant.Domin.Slid;
using ShopManagtemant.Infrastructure.ShopContext;

namespace ShopManagtemant.Infrastructure.Reposetory
{
    public class SliderReposetory:GenericReposetory<long,Slider>,ISliderReposetory
    {
        private readonly MyContext _context;

        public SliderReposetory(MyContext context) : base(context)
        {
            _context = context;
        }
    }
}
