using _0_Framework;

namespace ShopManagmant.Domin.Slid
{
    public class Slider:Golbaldomin
    {
        public string slidePicture { get; private set; }
        public string headingTitle { get; private set; }
        public string title { get; private set; }
        public string discription { get; private set; }
        public string Btntitle { get; private set; }
        public bool ISRemove { get; private set; }

        public Slider(string slidePicture, string headingTitle, string title, string discription, string btntitle)
        {
            this.slidePicture = slidePicture;
            this.headingTitle = headingTitle;
            this.title = title;
            this.discription = discription;
            Btntitle = btntitle;
            ISRemove = false;
        }
        public void Edited(string slidePicture, string headingTitle, string title, string discription, string btntitle)
        {
            this.slidePicture = slidePicture;
            this.headingTitle = headingTitle;
            this.title = title;
            this.discription = discription;
            this.Btntitle = btntitle;
           
        }

        public void Remove()
        {
            ISRemove = true;
        }

        public void Restore()
        {
            ISRemove = false;
        }


    }
}
