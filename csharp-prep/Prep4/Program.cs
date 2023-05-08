using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    
    {
       //Create a new list
         List<int> numbers = new List<int>();
         //Save the user number
         int userNumber = -1;
         //use while loop to start the list. If the user number is not 0, add all numbers from user.
         while(userNumber!= 0)
            {
             Console.WriteLine("Enter a list of numbers, type 0 when finished.");
              string userResponse = Console.ReadLine();
              userNumber = int.Parse(userResponse);
              //only add the number to the list if is not 0
               if (userNumber != 0)
                  {
                numbers.Add(userNumber);
                  }
            }
            
            //Add the numbers of the list. 
        int sum = 0;
        foreach (int number in numbers)
           {
            sum += number;
           }

         Console.WriteLine($"The sum is: {sum}");
             
           }
           //Compute the average sum divide the count of numbers.
         float average = ((float)sum) / numbers.Count;
         Console.WriteLine($"The average is: {average}");
         //Compute the max value
         int maxValue= numbers.Max();
         Console.WriteLine($"The max value is {maxValue}");
       
       

    }
}
