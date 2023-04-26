using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is the grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        
        string letter = "";

        if (number >= 90 ) {
           letter = "A";
        }
        else if ( number >= 80){
            letter = "B";

        }
        else if (number >=70){
            letter = "C";
        }
        else if (number >=60){
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"Your grade is : {letter}");

        if (number >=70){
            Console.WriteLine("You passed the course! Congrats.");
        }
        else {
            Console.WriteLine("You will do it next time, keep going!");
        }

    }
}