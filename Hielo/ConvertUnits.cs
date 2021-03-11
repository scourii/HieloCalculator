using System;
namespace Hielo
{
    class ConvertUnits
    {
        private decimal pounds { get; set; }
        private decimal kilograms { get; set; }
        private decimal lbtokg { get; set; }
        private decimal kgtolb { get; set; }
        private string inches { get; set; }
        private decimal centimeters { get; set; }
        private decimal cmconverted { get; set; }
        private decimal converted { get; set; }
        private string feet { get; set; }
        private decimal celsius { get; set; }
        private decimal fahrenheit { get; set; }
        private decimal onefoot = 12; // Used to divide to find the feet.
        SpecialCase ConvertToNormal = new SpecialCase(); // Used to convert variables with ' or / to a readable form.
        public void PoundsToKilograms()
        {
            Console.WriteLine("Enter pounds.");
            pounds = decimal.Parse(Console.ReadLine());
            lbtokg = pounds / 2.20462262185m;
            Console.WriteLine($"{pounds}lb is converted into {lbtokg}kg.");
        }
        public void KilogramsToPounds()
        {
            Console.WriteLine("Enter Kilograms:");
            kilograms = decimal.Parse(Console.ReadLine());
            kgtolb = kilograms * 2.20462262185m;
            Console.WriteLine($"{kilograms}kg is converted into {kgtolb}lb.");
        }
        public void InchesToCentimeters()
        {
            Console.WriteLine("Enter Inches/Feet(x'y):");
            inches = Console.ReadLine();
            if (inches.Contains("'"))
            {
                converted = ConvertToNormal.InchesSplit(inches);
                converted = converted * 2.54m;
                Console.WriteLine($"{inches}in is converted into {converted}cm.");
            }
            else{
                converted = decimal.Parse(inches);
                converted = converted * 2.54m;
                Console.WriteLine($"{inches}in is converted into {converted}cm.");
            }
        }
        public void CentimetersToInches()
        {
            Console.WriteLine("Enter centimeters:");
            centimeters = decimal.Parse(Console.ReadLine());
            cmconverted = centimeters / 2.54m;
            if(cmconverted >= onefoot)
            {
                decimal dividedbytwelve = Math.Round(cmconverted / 12, 2);
                string feet = dividedbytwelve.ToString();
                feet = feet.Replace(".", "'");
                Console.WriteLine($"{centimeters}cm is converted into {feet}ft.");
            }
            else
            {
                Console.WriteLine($"{centimeters}cm is converted into {cmconverted}in.");
            }

        }
        public void CelsiusToFahrenheit()
        {
            Console.WriteLine("Enter Celsius:");
            celsius = decimal.Parse(Console.ReadLine());
            fahrenheit = celsius + 32 * 1.8m;
            Console.WriteLine($"{celsius}°C is converted into {fahrenheit}°F."); 
        }
        public void FahrenheitToCelsius()
        {
            Console.WriteLine("Enter Fahrenheit:");
            fahrenheit = decimal.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) / 1.8m;
            Console.WriteLine($"{fahrenheit}°F is converted into {celsius}°C."); 
        }
    }
}