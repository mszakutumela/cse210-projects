using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        List<Video> videos = new();

        Video video1 = new("New Testament Come Follow Me (1-3 John, Jude) LOVE & LIGHT (Nov 27-Dec 3)", "Steve Scott", 31);
        Comment video1Comment1 = new("Benita Harline", "I absolutely LOVE you guys!!! You spread so much light in this dark world and I am extremely grateful for the great service you give in teaching us every week!!!");
        Comment video2Comment2 = new("Kristina Knopfel", "I love how you break down the lessons, we need more teachers like you at church! You have helped me teach and connect with my teen class in a different way, thank you.");
        Comment video3Comment3 = new("Earl Scoville", "When I see Him I will know Him because I will be like Him !  Wow ! short lesson but full of love , light and the spirit. Thank you. Love you bye ..........");

        video1.ListComment(video1Comment1);
        video1.ListComment(video2Comment2);
        video1.ListComment(video3Comment3);

        videos.Add

    }
}