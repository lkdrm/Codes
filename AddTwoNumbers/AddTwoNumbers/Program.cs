using AddTwoNumbers;

internal class Program
{
    private static void Main(string[] args)
    {
        var mC = new MakeCount();

        Console.WriteLine("Write random numbers, it will make an list and count it\nWill return reverse list\nFirst array:");
        var firstList = Console.ReadLine().ToArray();
        Console.WriteLine("Second array:");
        var secondList = Console.ReadLine().ToArray();
        Console.Write("[ ");
        foreach (var item in mC.TakeAndCount(firstList, secondList))
        {
            Console.Write(item + " ");
        }
        Console.Write("]");
    }
}