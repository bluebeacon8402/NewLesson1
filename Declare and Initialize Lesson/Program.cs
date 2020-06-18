using System;

namespace Declare_and_Initialize_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName = "Chris Sorge";
            int myAge = 38;
            char myGrade = 'A';
            bool Happy = true;
            double myMoney = 100.00;
            decimal myLocation = 55500.0034M;

            Console.WriteLine($"My name is{myName}, I am {myAge} years old");
            Console.WriteLine($"I got an {myGrade} on my assignment");
            Console.WriteLine($"It is very {Happy} that I enjoy eating food daily");
            Console.WriteLine($"I currently have {myMoney} dollars in my pocket");
            Console.WriteLine($"I was able to find {myLocation} donuts in my house");
        }
    }
}
