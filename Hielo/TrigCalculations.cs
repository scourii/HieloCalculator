using System;
using DecimalMath;

namespace Hielo
{
        public class TrigCalculations{
        private string strinConversions = string.Empty;
        private decimal degreesAns, Answer, referenceAng, FractionConverted, decimalConverted, LogNumber, BaseNumber, CalculatedLog;
        SpecialCase Fract = new SpecialCase();
        public void convertToDegrees(){
            Console.Write("Enter your degree.\n");
            degreesAns = decimal.Parse(Console.ReadLine());
            Answer = (DecimalEx.Pi / 180 ) * degreesAns;
            Console.Write($"{Answer} is your answer.\n");
        }
        public void convertToRadians(){
            Console.Write("Enter your radian:\n");
            degreesAns = decimal.Parse(Console.ReadLine());
            Answer = (180 / DecimalEx.Pi ) * degreesAns;
            Console.Write($"{Answer} is your answer.");
        }
        public void refAngleConv(){
            Console.Write("Enter the angle:\n");
            referenceAng = decimal.Parse(Console.ReadLine());
            if(referenceAng > 90) {referenceAng = 90 - referenceAng%90;
                Console.WriteLine($"Your reference angle is {referenceAng}.\n");
            }
            else if(referenceAng < -90) {referenceAng = 90 + referenceAng%90;
                Console.WriteLine($"Your reference angle is {referenceAng}.\n");
            }
            else {
                Console.WriteLine($"Your reference angle is {referenceAng}.\n");       
            }
        }
        public void findSin(){
            Console.Write("Enter the number:\n");
            string stringConversions = Console.ReadLine();
            if (stringConversions.Contains("/")){
                Fract.Fraction(stringConversions);
                FractionConverted = Fract.Fraction(stringConversions);
                Answer = FractionConverted;
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
            else{
                decimalConverted = Decimal.Parse(stringConversions);
                Answer = DecimalEx.Sin(decimalConverted);
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
        }
        public void findCos(){
            Console.Write("Enter the number:\n");
            string stringConversions = Console.ReadLine();
            if (stringConversions.Contains("/")){
                Fract.Fraction(stringConversions);
                FractionConverted = Fract.Fraction(stringConversions);
                Answer = DecimalEx.Cos(decimalConverted);
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
            else{
                decimalConverted = Decimal.Parse(stringConversions);
                Answer = DecimalEx.Cos(decimalConverted);
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
        }
        public void findTan(){
            Console.Write("Enter the number:\n");
            string stringConversions = Console.ReadLine();
            if (stringConversions.Contains("/")){
                Fract.Fraction(stringConversions);
                FractionConverted = Fract.Fraction(stringConversions);
                Answer = DecimalEx.Tan(decimalConverted);
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
            else{
                decimalConverted = Decimal.Parse(stringConversions);
                Answer = DecimalEx.Tan(decimalConverted);
                Console.WriteLine($"Your answer is {Answer}.\n");
            }
        }
        public void pythaGorTheorem(){
            Console.Write("Enter A:\n");
            decimal ASquared = decimal.Parse(Console.ReadLine());
            Console.Write("Enter B:\n");
            decimal BSquared = decimal.Parse(Console.ReadLine());
            Answer = DecimalEx.Sqrt((ASquared * ASquared) + (BSquared * BSquared));
            Console.Write($"C is {Answer}.\n");
        }
        public void LogarithmCalculation(){
            Console.WriteLine("Enter your number.");
            LogNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your base number.");
            BaseNumber = decimal.Parse(Console.ReadLine());
            CalculatedLog = DecimalEx.Log(LogNumber) / DecimalEx.Log(BaseNumber);
            Console.WriteLine($"Your answer is {CalculatedLog}.");
        }
    }
}