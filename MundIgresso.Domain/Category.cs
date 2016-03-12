namespace MundIgresso.Domain
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}