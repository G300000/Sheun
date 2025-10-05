# C# BMI Calculator

A simple console application for calculating Body Mass Index (BMI) using C#. The program prompts the user for their name, weight (in kilograms), and height (in meters), then calculates and displays their BMI along with a health classification based on the World Health Organization (WHO) standards.

## Features

- User-friendly console interface
- Calculates BMI from user input
- Provides feedback and classification:
  - Underweight
  - Normal weight
  - Overweight
  - Obesity (Class I, II, III)
- Displays WHO BMI classification list

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version compatible with your environment)
- A C#-compatible IDE (e.g., Visual Studio 2022)

### Running the Application

1. Clone the repository: git clone https://github.com/G300000/Sheun.git
2. Open the project in Visual Studio.
3. Build and run the application (`F5` or __Debug > Start Debugging__).

### Usage

1. Enter your name when prompted.
2. Enter your weight in kilograms.
3. Enter your height in meters.
4. View your BMI result and classification.

## Example Output

--------------------------------------
 WELCOME TO C# BMI CALCULATOR     
--------------------------------------
Enter your name: John   
Hi John, Please enter your weight in kilograms: 70   
Please enter your height in meters: 1.75   
Hi John, your BMI is: 22.857142. I'm happy and glad to say that you have a normal weight. Keep it stable and keep it cool!  

Standard WHO BMI Classification List:  
<18.5: Underweight  
18.5 - 24.9: Normal weight  
25.0 - 29.9: Overweight 30.0 - 34.9: Obesity (Class I)  
35.0 - 39.9: Obesity (Class II) - Severe Obesity  
\>=40.0: Obesity (Class III) - Morbid/Super Obesity  
Processing complete. Press any key to exit...  

## Notes

- The application does not handle invalid input; entering non-numeric values will cause it to crash.
- BMI calculation and classification are based on WHO standards.

## License

This project is licensed under the MIT License.
