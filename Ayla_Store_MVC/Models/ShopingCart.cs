using System;
using System.Collections.Generic;

namespace Ayla_Store_MVC.Models;

public partial class ShopingCart
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product Product { get; set; }
}
