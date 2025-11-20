using BookShop.DB.Entityes.Base;

namespace BookShop.DB.Entityes
{
    public class Category : NamedEntity
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}
