using System;

namespace RestAssesment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter State");
            var state = Console.ReadLine();
            new RestService().Getdetails(state).Result.ForEach(x => Console.WriteLine(x));
        }
    }
}
