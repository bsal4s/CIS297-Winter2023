using System;
using System.Collections.Generic;

namespace TestProject;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Number { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; } = new List<Section>();
}
