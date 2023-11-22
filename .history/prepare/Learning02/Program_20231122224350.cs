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
        job1._endYear = 2015;
        

        Job job2 = new Job();
        job2._companyName = "Google";
        job2._jobTitle = "Graphic Designer";
        job2._startYear = 2015;
        job2._endYear = 2021;
        
        // Console.WriteLine(job1._companyName);
        // Console.WriteLine(job2._companyName);

        Resume resume1 = new Resume();
        resume1._personName = "Ayanda Ndlovu";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.DisplayResume

    }
}