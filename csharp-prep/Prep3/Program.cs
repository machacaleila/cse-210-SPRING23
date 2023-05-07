using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Welcome to the Guess the number!");
        Random randomGenerator = new Random();
        int numb = randomGenerator.Next(1,101);
        int guess = -1;
        int attempts =0;
        while (guess != numb){
            Console.Write("What is your guess? : ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
             if ( guess < numb ) {
              Console.WriteLine("Higher"); 
             
              }
             else if (guess > numb) {
             Console.WriteLine("Lower");
             }
             else{
               Console.WriteLine("You guessed it!");
               Console.WriteLine("\n You took "+ attempts + " guesses");
               Console.WriteLine("Would you like to try again ? (y / n)");
               if(Console.ReadLine().ToLower() != "y") break;
             }
       
        }   
      
    }
}
