using System.ComponentModel.DataAnnotations;


namespace BookShop.DB.Entityes.Base
{
    public abstract class NamedEntity : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
