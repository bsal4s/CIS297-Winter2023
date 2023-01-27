using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOrientedStuff
{
    public class Cat : Mammal
    {
        public Cat(string name, string furColor, string gender, double weightInKilograms, int ageInYears)
            : base("Felis catus", name, furColor, gender, weightInKilograms, ageInYears)
        {

        }

        public override void Eat(double foodWeightInKilograms)
        {
            double weightFactorNotEatenDueToVomit = .75;
            // WeightInKilograms = 10;
            base.Eat(foodWeightInKilograms* weightFactorNotEatenDueToVomit);
        }

        
    }
}
