﻿using System;
using System.Collections.Generic;

namespace CoffeeShopProductListLab.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }

    public string? Category { get; set; }
}
