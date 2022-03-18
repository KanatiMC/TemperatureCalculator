using System;

class MainProgram{

     public static void Main (string[] args) {
         Console.Title = "Simple Temp Calculator";
        Console.WriteLine("Temperature Calculator");
        Console.WriteLine("");
        Console.WriteLine("1. To Fahrenheit");
        Console.WriteLine("2. To Celsius");
        Console.WriteLine("3. To Kelvin");
        Console.WriteLine("");
        string readLine = Console.ReadLine();
        if (readLine.Contains("1")){
            FahrenheitManager.Main();
        }
        if (readLine.Contains("2")){
            CelsiusManager.Main();
        }
        if (readLine.Contains("3")){
           KelvinManager.Main();
        }
        Console.ReadLine();
     } 
}