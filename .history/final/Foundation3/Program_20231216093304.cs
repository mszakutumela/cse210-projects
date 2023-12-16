using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();

        // Lecture details
        Address address1 = new("50 North Temple", "Salt Lake City", "Utah", "USA", 84150);
        string lectureAddress = address1.GetFullAddress();
        Lectures lecture = new("Some Lessons on Faith and Fear", "BYU Speeches", "10 May 2008", "12:00 pm", $"{lectureAddress}", "Lecture", "Gregory Clark", 300);
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        // Reception details
        Address address2 = new("222 End Street", "Lyttelton Manor", "Gauteng", "South Africa", 0157);
        string outdoorAddress = address2.GetFullAddress();
        Lectures lecture = new("For Time and All Eternity", "Ayanda's Wedding", "05 March 2023", "4:00 pm", $"{outdoorAddress}", "Reception", "To Be Announced", 75);
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        // Outdoor Gathering details
        Address address3 = new("Christina De Wit Ave", "Salt L", "Utah", "USA", 84150);
        string outdoorAddress = address3.GetFullAddress();
        Lectures lecture = new("Some Lessons on Faith and Fear", "BYU Speeches", "10 May 2008", "12:00 pm", $"{lectureAddress}", "Lecture", "Gregory Clark", 300);
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
    }
}