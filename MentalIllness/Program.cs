﻿namespace Websiteopener;

internal static class Webopener
{
    public static void Main()
    {
            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome!!");
        Console.WriteLine("In this program you can open your favorite website in one click :D");
        while (true) { 
            
            Console.WriteLine("Please choose one website from the list below");
            Console.WriteLine("gamesense");
            Console.WriteLine("youtube");
            Console.WriteLine("twitch");
            Console.WriteLine("google");
            var userFirstChoice = Console.ReadLine();
            if (string.IsNullOrEmpty(userFirstChoice)) 
            {
                Console.WriteLine("Invalid website...");
                continue;
            }

            if (userFirstChoice == "gamesense")
            {
                System.Diagnostics.Process.Start($"https://gamesense.pub/forums/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }
            if (userFirstChoice == "youtube")
            {
                System.Diagnostics.Process.Start($"https://www.youtube.com/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }

            if (userFirstChoice == "google")
            {
                System.Diagnostics.Process.Start($"https://www.google.pt/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }

            if (userFirstChoice == "twitch")
            {
                System.Diagnostics.Process.Start($"https://www.twitch.tv/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }
        }
    }
}