/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

using System.Security.Cryptography.X509Certificates;

class Scripture{
    private Reference _reference = new Reference();
    private string _verse;
    private List<Word> _words = new List<Word>();
    public Scripture(string verse)
    {
        _verse = verse;
        string[] words = _verse.Split(" ");

        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public void setReference(string book, int chapter, int verse, string verses = "")
    {
        _reference.setBook(book);
        _reference.setChapter(chapter);
        _reference.setVerse(verse);
        _reference.setVerses(verses);
    }

    public void hideWords()
    {
        Random generator = new Random();     
        int i = generator.Next(0,_words.Count);

        if (_words.Count % 2 == 0)
        {
            for (int x = 0; x < 2; x++)
            {
                while (_words[i].getStatus())
                 {
                    i = generator.Next(0, _words.Count);
                 }

                 _words[i].hideWord();
            }
        }
        else
        {
            while (_words[i].getStatus())
            {
                i = generator.Next(0, _words.Count);
            }

            _words[i].hideWord();
        }
    }

    public void displayScripture(){
        string parsedVerse = "";
        foreach (Word word in _words)
        {
            parsedVerse = parsedVerse + word.getWord() + " ";
        }

        Console.WriteLine($"{_reference.getReference()} {parsedVerse}");
    }

    public bool allHidden()
    {
        foreach (Word word in _words)
        {
            if (word.getStatus() == false)
            {
                return false;
            }
        }

        return true;
    }
}