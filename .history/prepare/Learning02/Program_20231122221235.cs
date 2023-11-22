using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        Job job1 = new Job();
        job1._companyName = "Adobe Inc";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2012;
        

        Job job2 = new Job();
        job2._companyName = "Google";
        job2._jobTitle = "Graphic Designer";
        
        // Console.WriteLine(job1._companyName);
        // Console.WriteLine(job2._companyName);

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}