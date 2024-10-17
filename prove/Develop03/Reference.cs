class Reference 
{
    private string _book;
    private string _chapter;
    private int _verse;
    private int _endVerse = 0;

    // Constructor 1
    public Reference(string book, string chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor 2
    public Reference(string book, string chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Propiedades para los setters y getters
    public string Book 
    {
        get { return _book; }
        set { _book = value; }
    }

    public string Chapter 
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int Verse 
    {
        get { return _verse; }
        set { _verse = value; }
    }

    public int EndVerse 
    {
        get { return _endVerse; }
        set { _endVerse = value; }
    }

    // Método para obtener el texto a mostrar
    public string GetDisplayText()
    {
        if (_endVerse != 0) 
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return $"{_book} {_chapter}:{_verse}";
    }
}
