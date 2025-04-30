using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagement.Entites;

public partial class Pepole
{
    public int PersonId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[]? Image { get; set; }
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
