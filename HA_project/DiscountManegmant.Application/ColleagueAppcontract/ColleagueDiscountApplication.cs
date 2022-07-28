using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using DiscountManegmant.Domin.Colleague_DiscountAgg;
using DiscountManegmant.Domin.ColleagueَDiscountAgg;

namespace DiscountManegmant.Application.ColleagueAppcontract
{
    public class ColleagueDiscountApplication : IColleagueDiscountApplication

    {
        private readonly IColleagueDiscountReposetory _reposetory;

        public ColleagueDiscountApplication(IColleagueDiscountReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult create(CreateColleagueDiscount command)
        {
            var operation = new OperationResult();
            var Ciscount = new ColleagueDiscount(command.DiscountRang, command.ProductId);
            _reposetory.Create(Ciscount);
            _reposetory.Save();

            return operation.Secusees();

        }

        public OperationResult Edited(Edited command)
        {
            var operation = new OperationResult();
            var test = _reposetory.GetById(command.id);
            test.Edited(command.DiscountRang, command.ProductId);
            _reposetory.Save();
            return operation.Secusees();
        }

        public Edited dtails(long id)
        {
            var com = _reposetory.GetById(id);
            return new Edited
            {
                id = com.Id,
                DiscountRang = com.DiscountRange,
                ProductId = com.ProductId
            };
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();

            var test = _reposetory.GetById(id);
           test.Remove();
           _reposetory.Save();
           return operation.Secusees();

        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();

            var test = _reposetory.GetById(id);
            test.Restor();
            _reposetory.Save();
            return operation.Secusees();

        }

        public List<ColleagueDiscountViewModel> all()
        {
            return _reposetory.all();
        }
    }
}
