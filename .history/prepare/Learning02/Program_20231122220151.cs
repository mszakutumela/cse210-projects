using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Adobe Inc";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._companyName = "Adobe Inc";


        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job1._companyName);
    }
}