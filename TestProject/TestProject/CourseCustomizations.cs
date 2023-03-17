using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Course
    {
        public override string ToString()
        {
            return $"ID: {Id} {Department}{Number} {Name}";
        }

        public string FullDescription => ToString() ;
    }
}
