using TwoSum;

public class Program
{
    private static void Main(string[] args)
    {
        var findNumber = new MakeCount();

        Console.WriteLine("Write your numbers for counting to find your target sum-number\nExample: 1,2,3\nTarget sum number: 4\nNumbers:");
        var userNumbers = Console.ReadLine().Split(",");
        
        Console.WriteLine("Write your target sum number:");
        int targetUserNumber = int.Parse(Console.ReadLine());

        findNumber.Numbers.AddRange(userNumbers.Select(int.Parse).ToList());

        Console.WriteLine("The result with using list:");

        Console.WriteLine($"Indexes of list which was used to find a target number are: {findNumber.FindTargetNumber(targetUserNumber)}");

        Console.WriteLine("The result with using array:");
        Console.WriteLine($"Indexes of list which was used to find a target number are : {findNumber.FindTargetNumber(userNumbers.Select(int.Parse).ToArray(), targetUserNumber)}");
    }
}