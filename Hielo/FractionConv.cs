using System;
namespace Hielo
{
    public class SpecialCase{
        private decimal simplified {get; set;}
        decimal feet {get; set;}
        decimal inches {get; set;}
        decimal numerator {get; set;}
        decimal denominator {get; set;}
        static decimal SafeDivision(decimal numerator, decimal denominator)
        {
            if (numerator == 0 || denominator == 0)
                throw new DivideByZeroException();
            return numerator / denominator;
        }
        public decimal Fraction(string FracTxt)
        {
            string[] pieces = FracTxt.Split('/');
            // Splits the string from something like 2/8 and converts it into .25.
            try
            {
                numerator = decimal.Parse(pieces[0]);
                denominator = decimal.Parse(pieces[1]);
                simplified = numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted to write by zero.");
            }
            return simplified;
        }
    // Function converts feet from something like 66.888 to the proper form.
    public decimal InchesSplit(string inchesTxt)
    {
        string[] pieces = inchesTxt.Split("'");
        feet = decimal.Parse(pieces[0]) * 12;
        inches = decimal.Parse(pieces[1]);
        simplified = feet + inches;
        return simplified;
    }
    }
}