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
        Lectures lecture = new("Some Lessons on Faith and Fear", "BYU Speeches", "10 May 2008", "12:00 pm", (Convert.ToString().$"{lectureAddress})", "Lecture", "Gregory Clark", 300);
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        // Reception details
        Address address2 = new("222 End Street", "Lyttelton Manor", "Gauteng", "South Africa", 0157);
        string receptionAddress = address2.GetFullAddress();
        Receptions reception = new("For Time and All Eternity", "Ayanda's Wedding", "05 March 2023", "4:00 pm", $"{receptionAddress}", "Reception", "misszandlovu@gmail.com");
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        // Outdoor Gathering details
        Address address3 = new("Christina De Wit Ave", "Pretoria", "Gauteng", "South Africa", 0027);
        string outdoorAddress = address3.GetFullAddress();
        OutDoorGatherings outdoor = new("Free Your Mind Hike", "Word of Wisdom Goal", "16 December 2023", "05:30 am", $"{outdoorAddress}", "Outdoor Gathering", "Cool");
        Console.WriteLine("_________________________________________________________________________________________________");

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullLectureDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
    }
}