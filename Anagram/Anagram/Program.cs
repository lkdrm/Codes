namespace Anagram;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This program will change your text to - Anagram.\nTo exit from programm write:'close'\nWrite your text:");
        try
        { 
            while (true)
            {
                var recivedStringFromUser = Console.ReadLine();

                if (recivedStringFromUser.Equals("close"))
                {
                    break;
                }

                Console.WriteLine("Result:");
                Console.WriteLine(Anagram.ReverseWords(recivedStringFromUser));

            }
            Console.WriteLine("The programm will close.");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Unexpected failed result.", ex.Message);
        }
    }
}