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

        private static readonly List<string> JokeList = new List<string>()
        {
            "Why don’t scientists trust atoms? Because they make up everything!",
            "I told my computer I needed a break, and now it won’t stop sending me KitKat ads.",
            "Why did the programmer quit his job? Because he didn't get arrays."

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
            var random = new Random();
            int index = random.Next(JokeList.Count);
            return JokeList[index];
        }


        public string WHoAmI()
        {
            return $"I am here to tell you a funny joke!";
        }
    }
}
