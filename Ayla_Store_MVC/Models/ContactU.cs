using System;
using System.Collections.Generic;

namespace Ayla_Store_MVC.Models;

public partial class ContactU
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Subject { get; set; }

    public string Description { get; set; }
}
