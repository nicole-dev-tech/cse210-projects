public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What inspired me today?",
        "What wa the best part of my day?",
        "what is something new i learned today?",
        "How did i see the work of the Lord today?",
        "what is the one thing that you regret doing today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];     
    }
}