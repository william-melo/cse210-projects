class ScriptureLoader
{
    // Lista privada de escrituras
    private List<Scripture> _scriptures = new List<Scripture>();

    // Getter para la lista de escrituras
    public List<Scripture> Scriptures
    {
        get { return _scriptures; }
        set { _scriptures = value; }
    }

    // Método para cargar escrituras desde un archivo
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("/");

            string scripture = parts[0];
            string book = parts[1];
            string chapter = parts[2];
            int verse = int.Parse(parts[3]);
            int endVerse = int.Parse(parts[4]);

            Reference reference = new Reference(book, chapter, verse, endVerse);
            Scripture newScripture = new Scripture(reference, scripture);

            _scriptures.Add(newScripture);
        }
    }
}
