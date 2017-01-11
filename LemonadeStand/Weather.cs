using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Weather
    {
        public double temperature;
        public string weatherType;
        public double temperatures;
        Random ChooseWeather = new Random();
        public Weather()
        {
        }

        public string WeatherForecast()
        {
            temperatures            = ChooseWeather.Next(1, 4);

            if (temperatures        == 1)
            {
                weatherType = "Sunny";
                temperature = ChooseWeather.Next(80, 110);
                DisplayWeatherAndTemperature();
                Console.WriteLine("Hot days are perfect to sell lemonades.\n");
                Console.WriteLine(" Now lets go shopping! ");
            }
            else if (temperatures   == 2)
            {
                weatherType = "Windy";
                temperature = ChooseWeather.Next(70, 80);
                DisplayWeatherAndTemperature();
                Console.WriteLine("It's very windy today but maybe lowering your price will bring cutomers.\n");
                Console.WriteLine(" Now lets go shopping! ");
            }
            else if (temperatures   == 3)
            {
                weatherType = "Raining";
                temperature = ChooseWeather.Next(50, 70);
                DisplayWeatherAndTemperature();
                Console.WriteLine("Raining days aren't good business days so be careful on the amount of lemonades made. \n");
                Console.WriteLine(" Now lets go shopping! ");
            }
            return weatherType;
        }      
        public void DisplayWeatherAndTemperature()
        {
            Console.WriteLine("The Weather today will be {0} and the temperature will be {1} degree", weatherType, temperature);

        }
    }
}