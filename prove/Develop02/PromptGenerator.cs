using System;
using System.Collections.Generic;

class PromptGenerator () 
{
  public List<string> _prompts = new List<string>
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What was the most challenging part of my day?",
    "What did I learn about myself today?",
    "What was the most beautiful thing I saw today?",
    "What was the most difficult thing I faced today?"
  };

  public string GetRandomPrompt() 
  {
    Random random = new Random();

    int indiceAleatorio = random.Next(_prompts.Count);
    string randomPrompt = _prompts[indiceAleatorio];

    return randomPrompt;
  }

  }