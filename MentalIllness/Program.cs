namespace Websiteopener;

internal static class Webopener
{
    public static void Main()
    {
            Console.ForegroundColor = ConsoleColor.Green;
        while (true) { 
            Console.WriteLine("Welcome!!");
            Console.WriteLine("In this program you can open your favorite website in one click :D");
            Console.WriteLine("Please choose one website from the list below");
            Console.WriteLine("gamesense");
            Console.WriteLine("youtube");
            Console.WriteLine("twitch");
            var userFirstChoice = Console.ReadLine();
             if (!int.TryParse(userFirstChoice, out int choice))
        {
            Console.WriteLine("Invalid website...");
        }

        }
    }
}