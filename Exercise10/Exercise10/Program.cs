namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //the menu
            int NewGame = 1;
            int LoadGame = 2;
            int Options = 3;
            int Quit = 4;

                Console.WriteLine(" ------------------");
                Console.WriteLine("|      Menu        |");
                Console.WriteLine("|  1 - New Game    |");
                Console.WriteLine("|  2 - Load Game   |");
                Console.WriteLine("|  3 - Options     |");
                Console.WriteLine("|  4 - Quit        |");
                Console.WriteLine(" ------------------");
                Console.Write("Select An Option (1, 2, 3, 4) :");
                int Response = int.Parse(Console.ReadLine());


            // if user Enters "New Game"
            if (Response == NewGame)
            {
                Console.WriteLine("Creating New Game ...");
            }   
            // if user Enter "Load game"
            if (Response == LoadGame)
            {
                Console.WriteLine("Loading Game ...");
            }
                // if user enters "Options"
            if (Response == Options)
            {
                Console.WriteLine("Loading Options");
            }
            //If user Enters "Quit" End Loop
            //Note: While (Answer! = 4)
            if (Response == Quit)
            {
                Console.WriteLine("Exiting Game");
            }
            while (Response != 4)
            {
                Console.WriteLine(" ------------------");
                Console.WriteLine("|      Menu        |");
                Console.WriteLine("|  1 - New Game    |");
                Console.WriteLine("|  2 - Load Game   |");
                Console.WriteLine("|  3 - Options     |");
                Console.WriteLine("|  4 - Quit        |");
                Console.WriteLine(" ------------------");
                Console.Write("Select An Option (1, 2, 3, 4) :");
                Response = int.Parse(Console.ReadLine());
                if (Response == NewGame)
                {
                    Console.WriteLine("Creating New Game ...");
                }
            
                if (Response == LoadGame)
                {
                    Console.WriteLine("Loading Game ...");
                }
              
                if (Response == Options)
                {
                    Console.WriteLine("Loading Options");
                }
                
                if (Response == Quit)
                {
                    Console.WriteLine("Exiting Game");

                
                }
                
            }

        }
    }
}