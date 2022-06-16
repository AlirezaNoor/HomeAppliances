using System.Reflection.Metadata;

namespace _0_Framework.Application
{
    public class OperationResult
    {
        public string title { get;  set; }
        public bool IsSucsses { get; set; }

        public OperationResult()
        {
            IsSucsses = false;
        }

        public OperationResult Secusees(string title="عملیات با موفقیت انجام شد")
        {
            IsSucsses = true;
            this.title = title;
            return this;
        }

        public OperationResult faild(string title= "عملیات با شکست مواجه شده است ،لطفا دوباره تلاش کنید ")
        {
            this.title = title;
                IsSucsses=false;
                return this;
        }
    }
}
