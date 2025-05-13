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
        public bool CanHandle(string input)
        {
            string[] words = input.ToLower().Split(' ');
            return words.Any(word => TriggerWords.Contains(word));
        }

        public string Handle(string input)
        {
            return "Today in Cairo: Sunny, 28°C.";
        }


        public string WHoAmI()
        {
            throw new NotImplementedException();
        }
    }
}
