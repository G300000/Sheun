using System;

class BMICalculator
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("     WELCOME TO C# BMI CALCULATOR     ");
        Console.WriteLine("--------------------------------------");
        Console.ResetColor();

        // Any input will do
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();

        // Note: If the user enters invalid input, the program will crash.
        Console.Write("Hi " + name + ", Please enter your weight in kilograms: ");
        float weight = float.Parse(Console.ReadLine());

        // Note: If the user enters invalid input, the program will crash.
        Console.Write("Please enter your height in meters: ");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float bmi = weight / (height * height);

        if (bmi < 18.5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hi " + name + ", your BMI is: " + bmi + ". Let's keep gaining weight, you are a bit underweight.");
            Console.ResetColor();
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + name + ", your BMI is: " + bmi + ". I'm happy and glad to say that you have a normal weight. Keep it stable and keep it cool!");
            Console.ResetColor();
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hi " + name + ", your BMI is: " + bmi + ". Let's keep do exercise, you are a bit overweight we can achieve great.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hi " + name + ", your BMI is: " + bmi + ". I'm sad to say that you are obese.");
            Console.ResetColor();
        }


        Console.WriteLine("\nStandard WHO BMI Classification List:");
        Console.WriteLine("  < 18.5: Underweight");
        Console.WriteLine("  18.5 - 24.9: Normal weight");
        Console.WriteLine("  25.0 - 29.9: Overweight");
        Console.WriteLine("  30.0 - 34.9: Obesity (Class I)");
        Console.WriteLine("  35.0 - 39.9: Obesity (Class II) - Severe Obesity");
        Console.WriteLine("  >= 40.0: Obesity (Class III) - Morbid/Super Obesity");

        Console.WriteLine("\n==============================================");

        Console.WriteLine("Processing complete. Press any key to exit...");
        Console.ReadKey();
    }
}

