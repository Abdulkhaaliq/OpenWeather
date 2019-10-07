using System;
using System.Threading.Tasks;
using WeatherGetter;
using OpenWeatherApp;
using WeatherData;

namespace OpenWeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Forcast to display here: ");

            WeatherBoy weatherBoy = new WeatherBoy();
            WeatherInfo weatherInfo = await WeatherBoy.GetWeatherAsync();

            Console.SetCursorPosition(5, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Temperature: " + weatherInfo.temp);

            Console.SetCursorPosition(5, 4);
            Console.Write("Pressure: " + weatherInfo.pressure);

            Console.SetCursorPosition(5, 6);
            Console.Write("Weather: " + weatherInfo.country);

            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Hope you enjoyed!!! :)");

        }

    }
}
