using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class ThanksSkill : ISkill
    {
        private static readonly HashSet<string> TriggerWords = new HashSet<string>()
        {
            "thanks","helped","merci","thank"
        };

        public bool CanHandle(string input)
        {
            string[] words = input.ToLower().Split(' ');
            return words.Any(word => TriggerWords.Contains(word));
        }

        public string Handle(string input)
        {
            
            return "You are welcome.I thank you for chatting with me today.";
        }

        public string WHoAmI()
        {
            return $"I am here to acknowledge you thanks.";
        }
    }
}
