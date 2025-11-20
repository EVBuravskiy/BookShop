using BookShop.DB.Entityes.Base;

namespace BookShop.DB.Entityes
{
    public class Book : NamedEntity
    {
        public virtual Category Category { get; set; }
    }
}
