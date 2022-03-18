using System;

class FahrenheitManager{
    public static void Main(){
        Console.WriteLine("1. Celcius To Fahrenheit");
        Console.WriteLine("2. Kelvin To Fahrenheit");
        Console.WriteLine("");
        string readLine = Console.ReadLine();
        if (readLine.Contains("1")){
            FahrenheitManager.C2F();
        }
        if (readLine.Contains("2")){
            FahrenheitManager.K2F();
        }
    }

     public static void C2F()
    {
        Console.WriteLine("Celsius To Fahrenheit");
        Console.WriteLine("Enter Value To Change to Fahrenheit");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) * 1.8f;
        float c2 = c1 + 32f;
        Console.WriteLine("Output: " + c2.ToString() + "f");
    }

    public static void K2F()
    {
        Console.WriteLine("Kelvin To Fahrenheit");
        Console.WriteLine("Enter Value To Change to Fahrenheit");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) - 273.15f;
        Console.WriteLine("Output: "+ c1.ToString() + "r");
    }
}