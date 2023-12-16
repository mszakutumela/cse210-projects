using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();

        Address address1 = new("50 North Temple", "Salt Lake City", "Utah", "USA", 84150);
        string lectureAddress = address1.GetFullAddress();
        Lectures lecture = new("Some Lessons on Faith and Fear", "BYU Speeches", "10 May 2008", "12:00 pm", $"{lectureAddress}", "Lecture", "Gregory Clark", 300);
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.
    }
}