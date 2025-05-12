namespace SkillSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Chatbot();

            while (true)
            {
                Console.Write("You: ");
                var input = Console.ReadLine();
                var response = bot.GetResponse(input);
                Console.WriteLine("Bot: " + response);
            }

        }
    }
}

/*
 *AIChatbotSkills/
│
├── Program.cs                  # Main entry point (Console App)
├── Chatbot.cs                  # Core chatbot engine
├── ISkill.cs                   # Interface for all skills
│
├── Skills/                     # Folder for modular skills
│   ├── JokeSkill.cs
│   ├── CalculatorSkill.cs
│   └── WeatherSkill.cs
│
├── SkillLoader.cs              # Dynamically loads all skills
├── Router.cs                   # Routes input to appropriate skill
└── Utils/                      # (Optional) Helper classes/utilities

 */
/*
 AIChatbotSkills/
│
├── Program.cs                  # Main entry point (Console App)
├── Chatbot.cs                  # Core chatbot engine
├── ISkill.cs                   # Interface for all skills
│
├── Skills/                     # Folder for modular skills
│   ├── JokeSkill.cs
│   ├── CalculatorSkill.cs
│   └── WeatherSkill.cs
│
├── SkillLoader.cs              # Dynamically loads all skills
├── Router.cs                   # Routes input to appropriate skill
└── Utils/                      # (Optional) Helper classes/utilities

 */