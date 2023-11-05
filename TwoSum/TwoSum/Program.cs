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

        var resultFromList = findNumber.FindTargetNumber(targetUserNumber);
        Console.WriteLine($"Indexes of List which was used to find a target number are: [{resultFromList[0]},{resultFromList[1]}]");
        var resultFromArray = findNumber.FindTargetNumber(userNumbers.Select(int.Parse).ToArray(), targetUserNumber);
        Console.WriteLine($"Indexes of Array which was used to find a target number are: [{resultFromArray[0]},{resultFromArray[1]}]");
    }
}