using System;

class KelvinManager{
    public static void Main(){
         Console.WriteLine("1. Fahrenheit To Kelvin");
        Console.WriteLine("2. Celcius To Kelvin");
        Console.WriteLine("");
          string readLine = Console.ReadLine();
        if (readLine.Contains("1")){
            KelvinManager.F2K();
        }
        if (readLine.Contains("2")){
            KelvinManager.C2K();
        }
    }

    public static void F2K()
    {
        Console.WriteLine("Fahrenheit To Kelvin");
        Console.WriteLine("Enter Value To Change to Kelvin");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) - 32f;
        float c2 = c1 * 5f;
        float c3 = c2 / 9f;
        float c4 = c3 + 273.15f;
        Console.WriteLine("Output: " + c4.ToString() + "k");
    }

    public static void C2K()
    {
        Console.WriteLine("Celsius To Kelvin");
        Console.WriteLine("Enter Value To Change to Kelvin");
        string readLine = Console.ReadLine();
        float c1 = float.Parse(readLine) + 273.15f;
        Console.WriteLine("Output: "+ c1.ToString() + "k");
    }
}