using BookShop.DB.Entityes.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.DB.Entityes
{
    public class Deal : Entity
    {
        public virtual ICollection<Book> Books { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Buyer Buyer { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
