using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class WeatherSkill : ISkill
    {
        private static readonly HashSet<string> TriggerWords = new HashSet<string>()
        {
            "forecast","weather","warm","sunny","temperature","cold","rainy"
        };

        private static readonly Dictionary<string, string> CityWeather = new()
        {
               { "cairo", "Sunny, 28°C" },
               { "london", "Cloudy, 16°C" },
               { "new york", "Rainy, 21°C" }
        };

        public bool CanHandle(string input)
        {
            string[] words = input.ToLower().Split(' ');
            return words.Any(word => TriggerWords.Contains(word));
        }

        public string Handle(string input)
        {
            string[] words = input.ToLower().Split(' ');
            foreach (var word in words)
            {
                if (CityWeather.ContainsKey(word))
                {
                    return $"Weather in {word}: {CityWeather[word]}";
                }
            }

            return "Sorry, I couldn't find weather info for that location.";
        }
    
        public string WHoAmI()
        {
            return $"I am here to help you everything about weather.";
        }
    }
}
