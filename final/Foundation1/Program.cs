using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Video One", "The YouTube Guy", 14);
        Video video2 = new Video("Cool Trick Shots", "coolTrickShotzDOOD", 4);
        Video video3 = new Video("what waz tat i saw in treees", "carboy2000", 1);

        List<Video> videos = new List<Video>{video1, video2, video3};

        Comment comment1 = new Comment("HAHA THAT WAS LOW KEY FUNNY","joe");
        Comment comment2 = new Comment("I AM SO CONFUSED RIGHT NOW","Wilma von Dockenshine");
        Comment comment3 = new Comment("WHAT DID I JUST WATCH","Elbert");
        
        Comment comment4 = new Comment("THEY BRING UP A GOOD POINT THOUGH","Gregory");
        Comment comment5 = new Comment("SMH","joe");
        Comment comment6 = new Comment("NO WAYYY","Phillip");
        
        Comment comment7 = new Comment("THAT WAS LIT!!","Timmy");
        Comment comment8 = new Comment("WOW KINDA LIFE CHANGING HONESTLY","Georgina");
        Comment comment9 = new Comment("HAHAH OK","joe");


        video1.StoreComment(comment1);
        video1.StoreComment(comment2);
        video1.StoreComment(comment3);

        video2.StoreComment(comment4);
        video2.StoreComment(comment5);
        video2.StoreComment(comment6);

        video3.StoreComment(comment7);
        video3.StoreComment(comment8);
        video3.StoreComment(comment9);

        foreach (Video video in videos)
        {
            Console.WriteLine("** \""+video._title+"\", "+video._author+", "+video._videoLength+" min, "+video.GetCommentCount()+" comments");
            foreach(Comment comment in video._comments)
            {
                Console.WriteLine(comment.GetComment()+"---"+comment.GetCommenter());
            }
        }
    }
}