using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Welcome to the YouTubeVideos");
        Console.WriteLine("====================================");

        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("C# Programming Tutorial", "John Doe", 360);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Python Programming Basics", "Jane Smith", 240);
        video2.AddComment(new Comment("David", "Nice introduction to Python!"));
        video2.AddComment(new Comment("Eve", "I love Python!"));
        video2.AddComment(new Comment("Frank", "Great for beginners!"));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("JavaScript for Web Development", "Alice Johnson", 180);
        video3.AddComment(new Comment("George", "JavaScript is awesome!"));
        video3.AddComment(new Comment("Hannah", "I prefer TypeScript."));
        video3.AddComment(new Comment("Ian", "JavaScript is the future!"));
        videos.Add(video3);

        /// Create fourth video
        Video video4 = new Video("OOP Concepts", "Michael Brown", 420);
        video4.AddComment(new Comment("Daniel", "Encapsulation makes more sense now!"));
        video4.AddComment(new Comment("Olivia", "never thought Abstraction could mean a lot here!"));
        video4.AddComment(new Comment("Sophia", "Nice examples as well"));
        videos.Add(video4);

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentInfo());
            }
            Console.WriteLine("------------------------------------");
        }



    }
}