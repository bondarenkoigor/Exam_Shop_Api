using System;
using System.Collections.Generic;

namespace Exam_Shop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int? Quantity { get; set; }

    public string? Picture { get; set; }

    public string? Model { get; set; }
}
