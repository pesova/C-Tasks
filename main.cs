using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    class bet9ja{
        static void Main(string[] args){
            int Age = 0;
            Console.Write("Welcome to bet9ja, Please enter your Age: ");
            Age = int.Parse(Console.ReadLine());
        if (Age >=18)
            {
                Console.WriteLine("You can now book your game");
                int[] odds = new int[4];

                odds[0] = 2;
                odds[1] = 4;
                odds[2] = 3;
                odds[3] = 1;

                Console.WriteLine("odd" + "=" + odds[0]);
                Console.WriteLine("odd" + "=" + odds[1]);
                Console.WriteLine("odd" + "=" + odds[2]);
                Console.WriteLine("odd" + "=" + odds[3]);

                Console.WriteLine(" ");
                Console.WriteLine("These are the teams");

                List<string> Teams = new List<string>();
                Teams.Add("Chelsea");
                Teams.Add("ManU");
                Teams.Add("Liverpool");
                Teams.Add("Barca");
                Console.WriteLine(" ");

                Console.WriteLine(Teams[0]);
                Console.WriteLine(Teams[1]);
                Console.WriteLine(Teams[2]);
                Console.WriteLine(Teams[3]);

                var ChosenTeam = "";
            Console.Write("Choose your team correctly: ");
            ChosenTeam = (Console.ReadLine());

            Console.Write("You are a fan of " + ChosenTeam);


            }else
            {
                Console.Write("you are young, leave here");
                
            }
        }
    }
}
