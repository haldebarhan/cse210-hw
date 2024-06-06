class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void VideoDetails()
    {
        List<int> times = ConvertSecondToTime(_length);
        Console.WriteLine($"title: {_title} by: {_author} time: {times[0]}h {times[1]}min");
        Console.WriteLine($"Comments: {NumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            comment.ShowComment();
        }
    }

    private static List<int> ConvertSecondToTime(int second)
    {
        int hours = second / 3600;
        int minutes = hours / 60;
        int remaining_seconds = second % 60;

        List<int> times = [hours, minutes, remaining_seconds];
        return times;
    }
}