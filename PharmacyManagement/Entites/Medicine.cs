using System;
using System.Collections.Generic;

namespace PharmacyManagement.Entites;

public partial class Medicine
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Number { get; set; }

    public DateOnly Edate { get; set; }

    public DateOnly MDate { get; set; }

    public int Quantity { get; set; }

    public decimal? PricePerUnit { get; set; }

    public byte[]? Image { get; set; }
}
