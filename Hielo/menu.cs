using System;

namespace Hielo
{  // Class to setup the menus used.
    public class MenuSetup{
        private enum MainMenuAction : int {
            // Binds all the functions to a number that is the same as the number in the menu.
            invalid = 0,
            basiccalculations = 1,
            convertdegreestoradian = 2,
            convertradianstodegrees = 3,
            referenceanglesolution = 4,
            findingsin = 5,
            findingcos = 6,
            findingtan = 7,
            logcalculator = 8,
            pythagoreantheory = 9,
            lbtokg = 10,
            kgtolb = 11,
            inchestocm = 12,
            cmtoinchestocm = 13,
            celsiustofahrenheit = 14,
            fahrenheittocelsiustofahrenheit = 15,

            exit = 16,
        }

        //Menu Text that is printed out everytime the program is executed.
        private static readonly string menuText = 
            "        Hielo Calculator\n" +
            "--------------------------------\n" +
            "[1] Basic Calculations\n" +
            "[2] Convert Degrees to Radians\n" +
            "[3] Convert Radians to Degrees\n" +
            "[4] Find the Reference Angle\n" +
            "[5] Find Sin\n" +
            "[6] Find Cos\n" +
            "[7] Find Tan\n" +
            "[8] Find Log\n" +
            "[9] Pythagorean Theory\n" +
            "[10] Convert Pounds to Kilograms\n" +
            "[11] Convert Kilograms to Pounds\n" +
            "[12] Convert Inches to Centimeters\n" +
            "[13] Convert Centimeters to Inches\n" +
            "[14] Convert Celsius to Fahrenheit\n" +
            "[15] Convert Fahrenheit to Celsius\n" +
            "[16] Exit";
        
        //Main menu function
        public void mainMenu()
        {
            do
            {
                //Prints out the menu
                Console.WriteLine(menuText);
                int choice;
                //Calls tryGetInput and parses choice.
                if (tryGetInput(out choice))
                {
                    //If choice = 10, ends program.
                    if (choice == (int)MainMenuAction.exit)
                    {
                        break;
                    }
                    //Calls each function depending on the number that you input.
                    handleMainMenuAction((MainMenuAction)choice);
                }
                //If it failes to parse.
                else{
                    throw new Exception("Failed to parse.");
                }
            } while (true);
        }
        //Parses choice to an integer so it can be read.
        private bool tryGetInput(out int input)
        {
            return int.TryParse(Console.ReadLine(), out input);
        }
        private void handleMainMenuAction(MainMenuAction action)
        {
            SpecialCase FractConv = new SpecialCase();
            TrigCalculations Calculate = new TrigCalculations();
            Evaluation Evalulate = new Evaluation();
            ConvertUnits ConvertUnits = new ConvertUnits();
            if (!Enum.IsDefined(typeof(MainMenuAction), action))
            {
                throw new Exception("Undefined number, please use 1-17."); // Throws an exception if the Number is not 1-17.
            }
            // Switch for all the different cases that the user inputs.
            switch (action)
            {
                // If the user inputs 1.
                case MainMenuAction.basiccalculations:
                    Console.Write("Enter your equation:\n");
                    string equation = Console.ReadLine();
                    decimal Answer = Evaluation.Evaluate(equation);
                    Console.Write(Answer);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 2.
                case MainMenuAction.convertdegreestoradian:
                    Calculate.convertToDegrees();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 3.
                case MainMenuAction.convertradianstodegrees:
                    Calculate.convertToRadians();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                //If the user inputs 4.
                case MainMenuAction.referenceanglesolution:
                    Calculate.refAngleConv();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 5.
                case MainMenuAction.findingsin:
                    Calculate.findSin();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 6.
                case MainMenuAction.findingcos:
                    Calculate.findCos();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 7.
                case MainMenuAction.findingtan:
                    Calculate.findTan();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 8.
                case MainMenuAction.logcalculator:
                    Calculate.LogarithmCalculation();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 9.
                case MainMenuAction.pythagoreantheory:
                    Calculate.pythaGorTheorem();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 10.
                case MainMenuAction.lbtokg:
                    ConvertUnits.PoundsToKilograms();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 11.
                case MainMenuAction.kgtolb:
                    ConvertUnits.KilogramsToPounds();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 12.
                case MainMenuAction.inchestocm:
                    ConvertUnits.InchesToCentimeters();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 13.
                case MainMenuAction.cmtoinchestocm:
                    ConvertUnits.CentimetersToInches();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 14.
                case MainMenuAction.fahrenheittocelsiustofahrenheit:
                    ConvertUnits.FahrenheitToCelsius();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // If the user inputs 15.
                case MainMenuAction.celsiustofahrenheit:
                    ConvertUnits.CelsiusToFahrenheit();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                
                // If the user inputs 16.
                case MainMenuAction.exit:
                    Environment.Exit(0);
                    break;
                case MainMenuAction.invalid:
                    throw new Exception("Undefined enum, please pick 1-16.");
            }
        }
    }
}