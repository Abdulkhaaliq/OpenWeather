using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherGetter;
using WeatherData;

namespace OpenWeatherApp
{
    public class WeatherBoy
    {

        public static async Task<WeatherInfo> GetWeatherAsync()
        {
            HttpClient httpClient = new HttpClient();
            string news = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=9d688038cb778406c25817c000155c75&units=metric");
            Info getter = JsonConvert.DeserializeObject<Info>(news);

            string returnString = string.Empty;

            int index = 0;

            var weatherInfo = new WeatherInfo();

            weatherInfo.temp = getter.main.temp;
            weatherInfo.pressure = getter.main.pressure;
            

            while (index < getter.weather.Count)
            {
                weatherInfo.country = getter.weather[index].Main;
                index++;
            }





            /** int index = 0;
             while (index < 1)
             {
                 /*Console.WriteLine(returnString = "description:" + getter.weather[index].description + " ");
                 Console.WriteLine(returnString += "main:" + getter.weather[index].Main + " ");
                 Console.WriteLine(returnString += "wind speed:" + getter.wind.speed + " ");
                 Console.WriteLine(returnString += "wind degrees:" + getter.wind.deg + " ");
                 Console.WriteLine(returnString += "Clouds:" + getter.clouds.all + " ");
                 Console.WriteLine(returnString += "humudity:" + getter.main.humidity + " ");
                 Console.WriteLine(returnString += "pressure:" + getter.main.pressure + " ");
                 Console.WriteLine(returnString += "Tempreture:" + getter.main.temp + " ");
                 Console.WriteLine(returnString += "City:" + getter.name + " ");*/


            //converts in Json format
            /*double temperature = getter.main.temp;
            string mainTemp = string.Empty;

            foreach (var Main in getter.main)
            {
                mainTemp = getter.name;
            }*/



            return weatherInfo;
        }      
    }  
}

