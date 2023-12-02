class Comment{
    private string _author;
    private string _comment;

    public Comment()
    {}

    public void setComment(string Comment){
        _comment = Comment;
    }
    public void setAuthor(string Author){
        _author = Author;
    }

    public string display(){
        return $"{_comment} - {_author}";
    }
    
}
