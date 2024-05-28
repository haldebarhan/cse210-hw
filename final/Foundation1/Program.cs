using System;

class Program
{
    static void Main(string[] args)
    {
        // Program 1: Abstraction with YouTube Videos
        Console.Clear();
        List<Video> videos = [];
        Video video1 = new("Captain America: The First Avenger", "Joe Johnston", 7440);
        Comment comment1 = new("reddiemurf81", "At the time it came out, this was my favorite MCU film. I don't know how this one could've been done much better.");
        Comment comment2 = new("contractorjohn2003", "Joe Johnston has done it again, managing to take what SHOULD be great action flick material and managed to make it, well, boring.");
        Comment comment3 = new("webspinner128", "Like many comic-book fans I was expecting the worst from this movie.");
        Comment comment4 = new("Baker-63", "I had my doubts that Chris Evans could pull off the modesty and heart needed for the role, but I was wrong.");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);


        Video video2 = new("Captain Marvel", " Anna Boden / Ryan Fleck", 7440);
        Comment comment5 = new("darthchris19", "The movie had some pacing issues with feel some scenes lasted for too long but the action scenes were excellent especially with Captain Americas shield which made a nice ding sound when it hit an opponent.");
        Comment comment6 = new("OrsonLannister", "kudos also to Hugo Weaving who very convincably portrayed the antagonist ");
        Comment comment7 = new("EUyeshima", "who has transformed himself into Red Skull, the super-powered head of HYDRA, the Nazi's occult research arm");
        Comment comment8 = new("Baker-69990", "Other actors fare just as well if somewhat predictably given the lack of true dimension they are given to play ");
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        video2._comments.Add(comment8);

        Video video3 = new("Iron Man", "Jon Favreau", 7200);
        Comment comment9 = new("user9898888", "At the time it came out, this was my favorite MCU film. I don't know how this one could've been done much better.");
        Comment comment10 = new("test2", "Joe Johnston has done it again, managing to take what SHOULD be great action flick material and managed to make it, well, boring.");
        Comment comment11 = new("Joe Dalton", "Like many comic-book fans I was expecting the worst from this movie.");
        Comment comment12 = new("Jason bourne", "I had my doubts that Chris Evans could pull off the modesty and heart needed for the role, but I was wrong.");
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);

        Video video4 = new("Iron Man 2 ", "Jon Favreau", 7440);
        Comment comment13 = new("welcomeMan", "At the time it came out, this was my favorite MCU film. I don't know how this one could've been done much better.");
        Comment comment14 = new("I'm the Best", "Joe Johnston has done it again, managing to take what SHOULD be great action flick material and managed to make it, well, boring.");
        Comment comment15 = new("legend09", "Like many comic-book fans I was expecting the worst from this movie.");
        Comment comment16 = new("skelethon", "I had my doubts that Chris Evans could pull off the modesty and heart needed for the role, but I was wrong.");
        video4._comments.Add(comment13);
        video4._comments.Add(comment14);
        video4._comments.Add(comment15);
        video4._comments.Add(comment16);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.VideoDetails();
            Console.WriteLine();
        }
    }
}