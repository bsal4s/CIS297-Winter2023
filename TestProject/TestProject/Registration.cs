using System;
using System.Collections.Generic;

namespace TestProject;

public partial class Registration
{
    public int Id { get; set; }

    public int SectionId { get; set; }

    public int StudentId { get; set; }

    public string Grade { get; set; } = null!;

    public virtual Section Section { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
