BMI Calculator Readme (C#) 📏
This is a simple C# console application designed to calculate the Body Mass Index (BMI) using a person's weight in kilograms and height in meters.

⚙️ Requirements
.NET Framework or .NET Core (C# environment) installed.

A text editor or IDE (such as Visual Studio or VS Code) to compile and run the code.

🛠️ How to Use
Compile the Code: Compile the C# source file (.cs) using your preferred method (e.g., dotnet build or within your IDE).

Run the Executable: Execute the compiled program.

Input Weight: The application will prompt you to enter the person's weight in kilograms (kg). This must be entered as a floating-point number (e.g., 75.5).

Input Height: The application will then prompt you to enter the person's height in meters (m). This must also be entered as a floating-point number (e.g., 1.78).

View Result: The calculated BMI will be displayed, along with a corresponding weight status category.

📝 Core Logic
The application uses the standard formula for calculating BMI:

BMI= 
Height (m) 
2
 
Weight (kg)
​
 
The calculation in C# will look something like this:

C#

float bmi = weight / (height * height);
Example Output:
BMI Range (kg/m²)	Weight Status Category
Below 18.5	Underweight
18.5 – 24.9	Normal Weight
25.0 – 29.9	Overweight
30.0 and Above	Obesity

Export to Sheets
(Note: These categories are generally accepted by organizations like the WHO, but local variations may exist.)
