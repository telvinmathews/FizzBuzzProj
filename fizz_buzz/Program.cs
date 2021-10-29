using System;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a for loop
            for (int index = 0; index <= 100; index++)
            {
                if (index % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (index % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            }
            //start loop at 0
            //contiue loop until 100
            //icrement by 1

            //use % to check if num is divisible by 3
            //print 'fizz'

            //check if num is divisible by 5
            //print 'buzz'

            //check if number is divisible by 3 and 5
            //print 'fizzbuzz'
        }
    }
}
