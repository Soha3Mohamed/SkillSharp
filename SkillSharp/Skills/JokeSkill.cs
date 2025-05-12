using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp.Skills
{
    internal class JokeSkill : ISkill
    {
        public bool CanHandle(string input)
        {
            return true;//just for testing
        }

        public string Handle(string input)
        {
            return "hello in joking world";
        }

        public string WHoAmI()
        {
            throw new NotImplementedException();
        }
    }
}
