using System;
using System.Collections.Generic;

namespace TestProject;

public partial class Instructor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string OfficeLocation { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; } = new List<Section>();
}
