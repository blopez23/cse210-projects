using System;

public class PromptGenerator{
    public string[] _prompts = new string[]
    {
        "What was the best part of my day?",
        "What is one blessing I've received today?",
        "What is one good thing I've done for a person this day?",
        "What is one thing you could do better during the day?",
        "What was the best interaction with a person I've had today?"    
    }; 

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}


