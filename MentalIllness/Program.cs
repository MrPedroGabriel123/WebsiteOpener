using System.Diagnostics;
using System.Security;
using System.ComponentModel;
namespace Websiteopener;

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
                var gamesense = "https://gamesense.pub/forums/";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = gamesense;
                System.Diagnostics.Process.Start(psi);
                System.Diagnostics.Process.Start($"https://gamesense.pub/forums/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }
            if (userFirstChoice == "youtube")
            {
                var youtube = "https://www.youtube.com/";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = youtube;
                System.Diagnostics.Process.Start(psi);

                System.Diagnostics.Process.Start($"https://www.youtube.com/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }

            if (userFirstChoice == "google")
            {
                var google = "https://www.google.pt/";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = google;

                System.Diagnostics.Process.Start($"https://www.google.pt/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }
                
            if (userFirstChoice == "twitch")
            {
                var twitch = "https://www.twitch.tv/";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = twitch;
                System.Diagnostics.Process.Start($"https://www.twitch.tv/");
                Console.WriteLine($"Opening {userFirstChoice}");
            }
        }
    }
}