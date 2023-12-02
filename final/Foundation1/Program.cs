using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listOfVideos = new List<Video>();

       //VIDEO 1//
        Video cookingVideo = new Video();
        cookingVideo.setAuthor("Gordon Ramsey");
        cookingVideo.setTitle("How to make chicken");
        cookingVideo.setLength(400);
        Comment cookingComment1 = new Comment();
        cookingComment1.setComment("This chicken sucks.");
        cookingComment1.setAuthor("Diego D.");
        Comment cookingComment2 = new Comment();
        cookingComment2.setComment("This chicken was amazing!!");
        cookingComment2.setAuthor("Emilio R.");
        Comment cc3 = new Comment();
        cc3.setComment("I will be sure to make this chicken again.");
        cc3.setAuthor("Wessly U.");
        cookingVideo.addComment(cookingComment1);
        cookingVideo.addComment(cookingComment2);
        cookingVideo.addComment(cc3);

        //VIDEO 2//
        Video soccerVideo = new Video();
        soccerVideo.setAuthor("Cristiano Ronaldo");
        soccerVideo.setTitle("Best way to make a freekick");
        soccerVideo.setLength(600);
        Comment soccerComment1 = new Comment();
        soccerComment1.setComment("What a nice technique!");
        soccerComment1.setAuthor("Jimmy C.");
        Comment soccerComment2 = new Comment();
        soccerComment2.setComment("Look at that curve.");
        soccerComment2.setAuthor("Fabrizio R.");
        Comment soccerComment3 = new Comment();
        soccerComment3.setComment("I wish a could play like that.");
        soccerComment3.setAuthor("Jason A.");
        soccerVideo.addComment(soccerComment1);
        soccerVideo.addComment(soccerComment2);
        soccerVideo.addComment(soccerComment3);

        //VIDEO 3//
        Video musicVideo = new Video();
        musicVideo.setAuthor("Ed Sheeran");
        musicVideo.setTitle("Releasing my new Song");
        musicVideo.setLength(800);
        Comment musicComment1 = new Comment();
        musicComment1.setComment("What a wholesome song!");
        musicComment1.setAuthor("Enrique L.");
        Comment musicComment2 = new Comment();
        musicComment2.setComment("I wish I could play the guitar like that");
        musicComment2.setAuthor("Kim K.");
        Comment musicComment3 = new Comment();
        musicComment3.setComment("I think it was not the best song.");
        musicComment3.setAuthor("Romeo S.");
        musicVideo.addComment(musicComment1);
        musicVideo.addComment(musicComment2);
        musicVideo.addComment(musicComment3);

        cookingVideo.display();
        soccerVideo.display();
        musicVideo.display();
    }
}