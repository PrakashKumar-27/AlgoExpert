namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        /* 1. Two Number Sum */
        var array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        var targetSum = 10;
        var result1 = TwoNumberSum.FindTwoNumberSum(array, targetSum);
        Console.WriteLine(string.Join(",", result1));

        /* 4. Tournament Winner*/
        TournamentWinner tournamentWinner = new TournamentWinner();
        List<List<string>> competitions = new List<List<string>>() { new List<string> { "HTML", "C#" }, new List<string> { "C#", "Python" }, new List<string> { "Python", "HTML" } };
        List<int> results = new List<int> { 0, 0, 1 };
        var result4 = tournamentWinner.FindTournamentWinner(competitions, results);
        Console.WriteLine(result4);
    }
}