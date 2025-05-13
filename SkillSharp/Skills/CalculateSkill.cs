using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class CalculateSkill : ISkill
    {
        private readonly static HashSet<string> TriggerWords = new HashSet<string>()
        {
            "calculate", "+","output","sum","multiply","output","count"
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
            return "The result is 6.";
        }


        public string WHoAmI()
        {
            throw new NotImplementedException();
        }
    }
}
