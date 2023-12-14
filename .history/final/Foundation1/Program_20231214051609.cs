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
        Comment video1Comment2 = new("Kristina Knopfel", "I love how you break down the lessons, we need more teachers like you at church! You have helped me teach and connect with my teen class in a different way, thank you.");
        Comment video1Comment3 = new("Earl Scoville", "When I see Him I will know Him because I will be like Him !  Wow ! short lesson but full of love , light and the spirit. Thank you. Love you bye ..........");

        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);

        videos.Add(video1);

        Video video2 = new("Come Follow Me New Testament (Nov. 13-19)", "Don't Miss This", 69);
        Comment video2Comment1 = new("Cathy Palmer", "'Sticks and stones may break some bones, but words will break a heart.'");
        Comment video2Comment2 = new("Ruth Lake", "I love the JOY and excitement from Grace and David as they teach us! I makes me excited about learning and keeping gospel principles.");
        Comment video2Comment3 = new("Juli Boyd", "It would be so so cool if you did a timeline like you did for the Old Testament. With pictures!");

        video2.Comment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videos.Add(video2);

        Video video3 = new("Revelation 1-5 | Dec 4 - Dec 10 | Come Follow Me Insights", "Scripture Central", 96);
        Comment video3Comment1 = new("Dianne Atkins", "I never read the book of revelation because it was scary and difficult to read,thanks for explaining so easy for all to understand.");
        Comment video3Comment2 = new("Charmaine Rawlings", "Thank you my brothers in the gospel for your time, you efforts to help me to understand the gospels better, i do value your efforts as it helps me draw closer to my Saviour");
        Comment video3Comment3 = new("Melanie Dunn", "I am so grateful to hear that you’ve come back, a lost sheep! I was one also, returning has made me so very happy. I am excited that you will serve a mission, there’s just nothing like feeling the Spirit and following Jesus.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);
        
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }





    }
}