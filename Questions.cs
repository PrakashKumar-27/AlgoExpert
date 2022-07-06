using AlgoExpert;

public abstract class Questions
{
    public virtual void Execute() => Console.WriteLine("Hello World!");
    public void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(',', array));
    }

    public void PrintListArray(List<int[]> array)
    {
        foreach (var arr in array)
        {
            Console.WriteLine(string.Join(',', arr));
        }
    }
}