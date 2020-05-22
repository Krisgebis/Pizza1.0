using System;

namespace Pizza
{
    class Pizza1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Pick your poison:");
            Console.WriteLine("1) Lønforhandling: The Game");
            Console.WriteLine("2) Adventures of Pizza");
            Console.WriteLine("3) FuzzBuzz: The Game");
            int foersteValg = Int32.Parse(Console.ReadLine());
            if (foersteValg == 1){
                Console.Clear();
                HelloWorld.Hello();
            }
            else if (foersteValg == 2){
                Console.Clear();
                int programKoerer = 1;
                while(programKoerer != 0){
                    var menu1  = new Menu(programKoerer);
                    menu1.ShowMenu();
                    var choice = Console.ReadLine();
                    if (choice.Equals("Exit")){
                        programKoerer = 0;
                    }
                    else {
                        int choiseInt = Int32.Parse(choice);
                    }
                }
            } 
            else if (foersteValg == 3){
                Console.Clear();
                Fuzz.FuzzBuzz();
            }
        }
    }
}