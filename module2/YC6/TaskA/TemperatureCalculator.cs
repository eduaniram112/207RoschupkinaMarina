using System;

public static class TemperatureCalculator
{
    public static double FromCelsiusToFahrenheit(double celsiusTemperature)
    {
        if (FromCelsiusToKelvin(celsiusTemperature) < 0) throw new ArgumentException("Incorrect input");
        return celsiusTemperature * 1.8 + 32;
    }

    public static double FromCelsiusToKelvin(double celsiusTemperature)
    {
        if (celsiusTemperature + 273.15<0) throw new ArgumentException("Incorrect input");
        return celsiusTemperature + 273.15;
    }

    public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
    {
        if (FromCelsiusToKelvin((fahrenheitTemperature - 32) * 5 / 9) < 0) throw new ArgumentException("Incorrect input");
        return (fahrenheitTemperature - 32) * 5 / 9;
    }

    public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
    {
        if (FromCelsiusToKelvin(FromFahrenheitToCelsius(fahrenheitTemperature)) < 0) throw new ArgumentException("Incorrect input");
        return FromCelsiusToKelvin(FromFahrenheitToCelsius(fahrenheitTemperature));
    }

    public static double FromKelvinToCelsius(double kelvinTemperature)
    {
        if (kelvinTemperature < 0) throw new ArgumentException("Incorrect input"); 
        return kelvinTemperature - 273.15;
    }

    public static double FromKelvinToFahrenheit(double kelvinTemperature)
    {
        if (kelvinTemperature < 0) throw new ArgumentException("Incorrect input");
        return FromCelsiusToFahrenheit(FromKelvinToCelsius(kelvinTemperature));
    }

}
