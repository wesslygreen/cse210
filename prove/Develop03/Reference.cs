/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _verses;
    public void setBook(string book){
        _book = book;
    }
    public void setChapter(int number){
        _chapter = number;
    }
    public void setVerse(int verse){
        _verse = verse;
    }

    public void setVerses(string verses){
        _verses = verses;
    }
    public string getReference(){
        string reference = "";
        if (_verse != 0)
        {
            reference = reference + _book + " " + _chapter  + ":" + _verse;
        }
        else
        {
            reference = reference + _book + " " + _chapter + ":" + _verses;
        }
        return reference;
    }
}
