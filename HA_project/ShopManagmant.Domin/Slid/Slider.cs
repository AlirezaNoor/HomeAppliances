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
        public string Link { get; private set; }

        public bool ISRemove { get; private set; }

        public Slider(string slidePicture, string headingTitle, string title, string discription, string btntitle, string link)
        {
            this.slidePicture = slidePicture;
            this.headingTitle = headingTitle;
            this.title = title;
            this.discription = discription;
            Btntitle = btntitle;
            Link = link;
            ISRemove = false;
        }
        public void Edited(string slidePicture,string link, string headingTitle, string title, string discription, string btntitle)
        {
            this.slidePicture = slidePicture;
            this.headingTitle = headingTitle;
            this.title = title;
            this.discription = discription;
            this.Btntitle = btntitle;
           this.Link=link;
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
