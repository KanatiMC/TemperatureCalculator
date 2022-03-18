using System;

class CelsiusManager{
    public static void Main(){
        Console.WriteLine("1. Fahrenheit To Celsius");
        Console.WriteLine("2. Kelvin To Celsius");
        Console.WriteLine("");
        string readLine = Console.ReadLine();
        if (readLine.Contains("1")){
            CelsiusManager.F2C();
        }
        if (readLine.Contains("2")){
            CelsiusManager.K2C();
        }
    }
    public static void F2C()
    {
        Console.WriteLine("Fahrenheit To Celsius");
        Console.WriteLine("Enter Value To Change to Celsius");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) - 32f;
        float c2 = c1 / 1.8f;
        Console.WriteLine("Output: " + c2.ToString() + "c");
    }
    public static void K2C()
    {
        Console.WriteLine("Fahrenheit To Celsius");
        Console.WriteLine("Enter Value To Change to Celsius");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) - 273.15f;
        float c2 = c1 * 9f;
        float c3 = c2 / 5f;
        float c4 = c3 + 32f;
        Console.WriteLine("Output: "+ c1.ToString() + "c");
    }
}