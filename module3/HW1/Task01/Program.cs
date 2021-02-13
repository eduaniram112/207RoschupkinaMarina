using System;
// задача 3 из презентации 1
namespace Task01
{
    delegate double delegateConvertTemperature(double t);

    class TemperatureConvertInp
    {
        public double CelsiusToFahrenheit(double t) => 9.0 / 5.0 * t + 32;

        public double FahrenheitToCelsius(double t) => 5.0 / 9.0 * (t - 32);
    }

    static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double t) => t + 273.15;

        public static double KelvinToCelsius(double t) => t - 273.15;
        
        public static double CelsiusToRankin(double t) => 9.0 / 5.0 * t + 491.67;
        
        public static double RankinToCelsius(double t) => 5.0 / 9.0 * (t - 491.67);
    }


    class Program
    {

        static void Main(string[] args)
        {
            TemperatureConvertInp obj = new TemperatureConvertInp();

            delegateConvertTemperature CtF = obj.CelsiusToFahrenheit;
            delegateConvertTemperature FtC = obj.FahrenheitToCelsius;
            Console.WriteLine($"0 C to F: {CtF?.Invoke(0)}; 0 F to C {FtC?.Invoke(0)}");


            delegateConvertTemperature CtK = StaticTempConverters.CelsiusToKelvin;
            delegateConvertTemperature KtC = StaticTempConverters.KelvinToCelsius;

            delegateConvertTemperature CtR = StaticTempConverters.CelsiusToRankin;
            delegateConvertTemperature RtC = StaticTempConverters.RankinToCelsius;

            delegateConvertTemperature[] converters = { CtF, CtK, CtR,};

            double t;
            Console.Write("Celsius: ");
            double.TryParse(Console.ReadLine(), out t);
                foreach (delegateConvertTemperature cnv in converters)
                {
                    string str = cnv.Method.ToString();
                    Console.WriteLine($"{str.Substring(16, str.Length - 24)}: {cnv?.Invoke(t)}");
                }
            
            
        }
    }
}

