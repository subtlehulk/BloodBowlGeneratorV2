namespace BloodBowlGeneratorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Blood Bowl action generator that generates a random sequence of actions you can take for your player.

            //Version 2 - randomly generates the order of the actions to be taken. The user will determine which players take the actions.
            Welcome();
            StartGame();

        }

        static void StartGame()
        {
            bool play = true;
            int counter = 0;
            
            while (play)
            {
                List<string> actions = new List<string>();
                while (actions.Count() != 4)
                {

                    Random rng = new Random();
                    int num = rng.Next(1, 5);
                
                    string action;

                    counter++;

                    switch (num)
                    {
                        case 1:
                            action = "Move Player";
                            if (!actions.Contains(action))
                            {
                                actions.Add(action);
                            }
                            break;
                        case 2:
                            action = "Pass / Throw Team Mate";
                            if (!actions.Contains(action))
                            {
                                actions.Add(action);
                            }
                            break;
                        case 3:
                            action = "Block";
                            if (!actions.Contains(action))
                            {
                                actions.Add(action);
                            }
                            break;
                        case 4:
                            action = "Blitz / Get Up";
                            if (!actions.Contains(action))
                            {
                                actions.Add(action);
                            }
                            break;
                    }
                }
                int index = 0;
                foreach (var item in actions)
                {
                    
                    index++;
                    Console.WriteLine("{0}. {1}", index, item);
                    
                }
                System.Console.WriteLine("-------------------");
                Console.ReadKey();
            }

        }

        static void Welcome()
        {
            Console.WriteLine(" ************************************************************\n");

            Console.WriteLine("   Welcome to the Blood Bowl Action Generator Version 2.0.0.");

            Console.WriteLine("\n ************************************************************");

        }


    }
}