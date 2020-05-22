using System;

namespace Fuzz
{
    class FuzzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FuzzBuzz: The Game");
            Console.WriteLine("1) Play the Game");
            Console.WriteLine("2) Rules");
            Console.ReadLine();
            int fuzzMenu = Int32.Parse(Console.ReadLine());
            if (fuzzMenu == 1){
                Console.Clear();
                FuzzGame();
            }
            else if (fuzzMenu == 2){
                Console.Clear();
                Console.WriteLine("You must input the right respons, depending on the next number in line.");
                Console.WriteLine("We start with 1 and increase this number in increments of 1 each turn.");
                Console.WriteLine("You press enter to get the next number, UNLESS it can be devided by 3 or 5.");
                Console.WriteLine("");
            FuzzBuzz();
            }
        }
    }
    class FuzzGame
    {
          Int16 fuzzCount = 0;
            while (gameLost == false){
                Console.Clear();
                Console.ReadKey();
    }
    class FuzzCheck
    {
        fuzzCount 
    }
}