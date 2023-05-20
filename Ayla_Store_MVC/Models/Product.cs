namespace Ayla_Store_MVC.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public string? Photo { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<ShopingCart> ShopingCarts { get; set; } = new List<ShopingCart>();
}
