using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class JokeSkill : ISkill
    {
        private static readonly HashSet<string> TriggerWords = new HashSet<string>()
        {
            "joke", "funny" , "laugh" , "smile" , "laughing" , "joking" , "smiling"
        };
        public bool CanHandle(string input)
        {
            
            string[] words = input.ToLower().Split(' ');
            #region code not refactored
            //foreach (string word in words)
            //{
            //    if (TriggerWords.Contains(word)) return true;
            //}
            //return false;
            #endregion

            return words.Any(word => TriggerWords.Contains(word)); //better readability
        }

        public string Handle(string input)
        {
            return "Why don’t skeletons fight each other? They don’t have the guts.";
        }


        public string WHoAmI()
        {
            throw new NotImplementedException();
        }
    }
}
