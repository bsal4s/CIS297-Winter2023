using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOrientedStuff
{
    public class Mammal
    {
        public string Species { get; }
        public string Name { get; set; }
        public string FurColor { get; set; }
        public string Gender { get; set; }
        public double WeightInKilograms { get; protected set; }
        public int AgeInYears { get; }

        public Mammal(string species, string name, string furColor, string gender, double weightInKilograms, int ageInYears)
        {
            Species = species;
            Name = name;
            FurColor = furColor;
            Gender = gender;
            WeightInKilograms = weightInKilograms;
            AgeInYears = ageInYears;
        }

        public virtual void Eat(double foodWeightInKilograms)
        {
            WeightInKilograms += foodWeightInKilograms;
        }

    }
}
