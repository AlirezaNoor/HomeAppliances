namespace _0_Framework
{
    public class Golbaldomin
    {
        public long Id { get; private set; }
        public DateTime datetime { get; private set; }

        public Golbaldomin()
        {
            this.datetime = DateTime.Now;
        }
    }
}