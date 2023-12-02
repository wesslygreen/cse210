using System.Runtime.CompilerServices;
using System.Transactions;
class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> listOfComments = new List<Comment>();

    public Video()
    {}

    public void setTitle(string title){
        _title = title;
    }
    public void setAuthor(string author){
        _author = author;
    }
    public void setLength(int length){
        _length = length;
    }
    public void addComment(Comment comment){
        listOfComments.Add(comment);
    }

    public void display()
    {
        Console.WriteLine($"{_title} by {_author}, {_length} seconds long, {listOfComments.Count} comments:");
        int index = 1;
        foreach (Comment comment in listOfComments)
        {
            Console.WriteLine($"{index}. {comment.display()}");
            index++;
        }
        Console.WriteLine();
    }

}

