﻿using System;
using System.Collections.Generic;

namespace Ayla_Store_MVC.Models;

public partial class AspNetRoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual AspNetRole Role { get; set; }
}
