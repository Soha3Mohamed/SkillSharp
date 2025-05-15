# SkillSharp

SkillSharp is a modular chatbot framework built with C# and .NET Core, designed to handle diverse user inputs through a pluggable skill system. Each skill encapsulates specific functionality, allowing for clean separation of concerns and easy scalability.

🧠 Features
Modular Skill Architecture: Implement new functionalities by creating classes that adhere to the ISkill interface.

Dynamic Skill Routing: The chatbot evaluates user input and delegates processing to the appropriate skill(s).

Sample Skills Included:

JokeSkill: Delivers a random joke.

TimeSkill:Provides Time now.

WeatherSkill: Provides mock weather information for predefined cities.

🚀 Getting Started
Clone the repository:

bash
Copy
Edit
git clone https://github.com/Soha3Mohamed/SkillSharp.git
Navigate to the project directory:

bash
Copy
Edit
cd SkillSharp
Build and run the project using your preferred .NET development environment.

🛠️ Extending SkillSharp
To add a new skill:

Create a class that implements the ISkill interface.

Define the CanHandle(string input) method to determine if the skill should process the input.

Implement the Handle(string input) method to provide the skill's response.

Register the new skill in the chatbot's skill list.

📚 Future Enhancements
Entity Framework Core Integration: Persist data such as jokes, user interactions, or configurations.

External API Support: Fetch real-time data for skills like weather or news.

Advanced Natural Language Processing: Improve input parsing and intent recognition.

📄 License
This project is licensed under the MIT License.
