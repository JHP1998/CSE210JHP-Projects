class Video
{
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comment> _comments{ get; set; }
    public void AddComment(string commenterName, string commentText)
    {
        //Add new comment to comments list
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
}