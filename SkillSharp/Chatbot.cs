using SkillSharp.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp
{
    internal class Chatbot
    {
        List<ISkill> _skills = new List<ISkill> { new JokeSkill(), new CalculateSkill() , new WeatherSkill()};
        string UserInput;
        public Chatbot( )
        {

        }
        public string GetResponse(string input)
        {
            for (int i = 0; i < _skills.Count; i++)
            {

                if (_skills[i].CanHandle(input))
                {
                    //for now , stop after first match but later I am thinking of adding a confidence level to decide based on it.
                    return _skills[i].Handle(input);  
                }

            }
            return "Sorry, I didn't understand. ";
        }
    }
}
