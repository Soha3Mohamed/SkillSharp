using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class TimeSkill : ISkill
    {
        private readonly static HashSet<string> TriggerWords = new HashSet<string>()
        {
            "time", "date","today","clock","hour"
        };
        public bool CanHandle(string input)
        {
            string[] words = input.ToLower().Split(' ');
            return words.Any(word => TriggerWords.Contains(word));
        }

        public string Handle(string input)
        {
            // Extract and evaluate simple math expression
            // Example: "what is 4 + 2"
            return (DateTime.Now).ToString();
        }


        public string WHoAmI()
        {
            return $"I am here to tell you the current time!";
        }
    }
}
