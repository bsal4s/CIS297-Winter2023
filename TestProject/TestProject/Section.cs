using System;
using System.Collections.Generic;

namespace TestProject;

public partial class Section
{
    public int Id { get; set; }

    public int CourseId { get; set; }

    public string Semester { get; set; } = null!;

    public string DayTime { get; set; } = null!;

    public int InstructorId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; } = new List<Registration>();
}
