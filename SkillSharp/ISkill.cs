using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp
{
    //every skill must implement this interface ( i need some way to make sure of that in chatbot)
    public interface ISkill
    {
        public bool CanHandle(string input); //this function responds with yes or not based on words in the user input, thinking later of adding a confidence level fot better decisions in chatbot

        public void Handle(string input);//returns a string or answer from a hardcoded list for now but then i will integrate with databases( as i get better in ef core)

        public string WHoAmI(); //metadata about the skill

    }
        
}
