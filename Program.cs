using System;

namespace Building_Blocks
{
    internal class Program
    {
        static void Main()
        {
            //"make some vars, print them out"
            string bird = "Heron";
            int number = 27;
            bool friend = true;
            Console.WriteLine("I see a " + bird +"!\nNo, make that " + number + " " + bird +"s.");
            Console.WriteLine("But is it a friend?");
            if (friend == true)
            {
                Console.WriteLine("Indeed it is!");
            } else
            {
                Console.WriteLine("No it is not :(");
            }

            //"make a method that prints out instructor name"
            //Call method
            InstructorName();
            //Define methods
            static void InstructorName()
            {
                Console.Write("\n");
                Console.WriteLine("Who is the instructor?");
                string teacher = "Nick";
                Console.WriteLine(teacher + " is the instructor!");
            }
            
            //make a method that takes in 2 nums, adds them, then returns
            //print out result
        }
        
    }
}