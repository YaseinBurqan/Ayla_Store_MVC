using System;
using System.Collections.Generic;

namespace Ayla_Store_MVC.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public string Photo { get; set; }

    public int? Quantity { get; set; }

    public string Type { get; set; }

    public string SupplierName { get; set; }

    public DateTime? EntryDate { get; set; }

    public string ReviewUrl { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ShopingCart> ShopingCarts { get; set; } = new List<ShopingCart>();
}
