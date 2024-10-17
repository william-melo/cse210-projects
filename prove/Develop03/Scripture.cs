using System;
using System.Collections.Generic;
using System.Linq;

class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += $" {word.GetDisplayText()}";
        }
        return displayText.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomNumber = random.Next(0, _words.Count);
            Word randomWord = _words[randomNumber];

            if (!randomWord.IsHidden)
            {
                randomWord.IsHidden = true;
                randomWord.Hide();
                _words[randomNumber] = randomWord;
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
