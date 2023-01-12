using System.Diagnostics.CodeAnalysis;

namespace Week2_TaxEstimator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int STANDARD_DEDUCTION = 12_950;
            const int START_OF_10_PERCENT_BRACKET = 0;
            const int START_OF_12_PERCENT_BRACKET = 10_275;
            const int START_OF_22_PERCENT_BRACKET = 41_775;
            const int START_OF_24_PERCENT_BRACKET = 89_075;
            const int START_OF_32_PERCENT_BRACKET = 170_050;
            const int START_OF_35_PERCENT_BRACKET = 215_950;
            const int START_OF_37_PERCENT_BRACKET = 539_900;


            

            Console.WriteLine("How many W2s do you have to enter");
            int w2Count = Convert.ToInt32(Console.ReadLine());
            int grossIncome = 0;
            for ( int w2 = 0; w2 < w2Count; w2++ ) {
                Console.WriteLine($"Enter your income from W2 #{w2 + 1}");
                grossIncome += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Your gross income is ${grossIncome}");

            int totalDeductions = 0;
            int dedution = 0;

            while ( dedution != -1)
            {
                totalDeductions += dedution; 
                Console.WriteLine("Enter a deduction or -1 to stop");
                dedution = Convert.ToInt32(Console.ReadLine());
            }
            
            if ( totalDeductions < STANDARD_DEDUCTION)
            {
                totalDeductions = STANDARD_DEDUCTION;
            }

            Console.WriteLine($"Your total deductions are ${totalDeductions}");

            int adjustedGrossIncome = grossIncome - totalDeductions;

            Console.WriteLine($"Your adjusted gross income is {adjustedGrossIncome}");

            double taxesOwedAt10Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_10_PERCENT_BRACKET, START_OF_12_PERCENT_BRACKET, .1);
            double taxesOwedAt12Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_12_PERCENT_BRACKET, START_OF_22_PERCENT_BRACKET, .12);
            double taxesOwedAt22Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_22_PERCENT_BRACKET, START_OF_24_PERCENT_BRACKET, .22);
            double taxesOwedAt24Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_24_PERCENT_BRACKET, START_OF_32_PERCENT_BRACKET, .24);
            double taxesOwedAt32Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_32_PERCENT_BRACKET, START_OF_35_PERCENT_BRACKET, .32);
            double taxesOwedAt35Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_35_PERCENT_BRACKET, START_OF_37_PERCENT_BRACKET, .35);
            double taxesOwedAt37Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_37_PERCENT_BRACKET, int.MaxValue, .37);

            Console.WriteLine($"Taxes at 10% : ${taxesOwedAt10Percent}");
            Console.WriteLine($"Taxes at 12% : ${taxesOwedAt12Percent}");
            Console.WriteLine($"Taxes at 22% : ${taxesOwedAt22Percent}");
            Console.WriteLine($"Taxes at 24% : ${taxesOwedAt24Percent}");
            Console.WriteLine($"Taxes at 32% : ${taxesOwedAt32Percent}");
            Console.WriteLine($"Taxes at 35% : ${taxesOwedAt35Percent}");
            Console.WriteLine($"Taxes at 37% : ${taxesOwedAt37Percent}");

            double totalTaxesOwed = taxesOwedAt10Percent +
                taxesOwedAt12Percent +
                taxesOwedAt22Percent +
                taxesOwedAt24Percent +
                taxesOwedAt32Percent +
                taxesOwedAt35Percent +
                taxesOwedAt37Percent;

            Console.WriteLine($"Total taxes owed: ${totalTaxesOwed}");


            Console.WriteLine($"Taxes owed as % of gross income: ${totalTaxesOwed / grossIncome * 100}");
            Console.WriteLine($"Taxes owed as % of adjusted gross income: ${totalTaxesOwed / adjustedGrossIncome * 100}");

            // another approach
            //int incomeToBeTaxed = adjustedGrossIncome;
            //if (incomeToBeTaxed > START_OF_37_PERCENT_BRACKET)
            //{
            //    taxesOwedAt37Percent = (incomeToBeTaxed - START_OF_37_PERCENT_BRACKET) * .37;
            //    incomeToBeTaxed = START_OF_37_PERCENT_BRACKET;
            //}
            //if (incomeToBeTaxed > START_OF_35_PERCENT_BRACKET)
            //{
            //    taxesOwedAt37Percent = (incomeToBeTaxed - START_OF_35_PERCENT_BRACKET) * .35;
            //    incomeToBeTaxed = START_OF_35_PERCENT_BRACKET;
            //}

        }

        static double getTaxesAtBracket(int income, int startOfBracket, int endOfBracket, double taxRate)
        {
            if ( income > endOfBracket)
            {
                return (endOfBracket - startOfBracket) * taxRate;
            }
            else if ( income < startOfBracket )
            {
                return 0;
            }
            else
            {
                return (income - startOfBracket) * taxRate;
            }
        }
    }
}