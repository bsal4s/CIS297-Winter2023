using System;
using System.Collections.Generic;

namespace TestProject;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Major { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; } = new List<Registration>();
}
