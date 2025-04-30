using System;
using System.Collections.Generic;

namespace PharmacyManagement.Entites;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int PersonId { get; set; }

    public string Role { get; set; } = null!;

    public virtual Pepole Person { get; set; } = null!;
}
