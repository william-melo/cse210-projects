using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static Random random = new Random();  // Inicialización del generador de números aleatorios

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

        // Añadir la referencia al texto
        string referenceText = _reference.GetDisplayText();
        referenceText += $"{displayText}";
        return referenceText.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        
        while (hiddenCount < numberToHide)
        {
            int randomNumber = random.Next(0, _words.Count);  // Generar un número aleatorio
            Word randomWord = _words[randomNumber];

            if (!randomWord.IsHidden)  // Solo ocultar si no está oculto
            {
                randomWord.Hide();  // Ocultar palabra
                hiddenCount++;      // Aumentar el contador de palabras ocultas
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);  // Verificar si todas las palabras están ocultas
    }
}
