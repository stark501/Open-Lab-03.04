using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
                return ("even");
}
            else
            {
                Console.WriteLine("Number is odd");
                return ("odd");
           }

        }
    }
}
