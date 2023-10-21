/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

using System.Dynamic;
using System.Net;

class Word
{
    private string _word;
    private bool isHidden = false;
    public Word(string word){
        _word = word;
    }
    public void hideWord(){
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord = hiddenWord + " ";
        }
        isHidden = true;
        _word = hiddenWord;
    }

    public string getWord(){
        return _word;
    }

    public bool getStatus()
    {
        return isHidden;
    }
}