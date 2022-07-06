using AlgoExpert;

public class Simple : Questions
{
    public override void Execute()
    {
        /* 1. Two Number Sum */
        var array1 = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        var targetSum = 10;
        var result1 = TwoNumberSum.FindTwoNumberSum(array1, targetSum);
        PrintArray(result1);

        /* 2. Validate Subsequence*/
        var array2 = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
        var sequence = new List<int> { 1, 6, -1, 10 };
        var result2 = ValidateSubsequence.IsValidSubsequenceSolutionOne(array2, sequence);
        Console.WriteLine(result2);
        result2 = ValidateSubsequence.IsValidSubsequenceSolutionTwo(array2, sequence);
        Console.WriteLine(result2);


        /* 4. Tournament Winner*/
        TournamentWinner tournamentWinner = new TournamentWinner();
        List<List<string>> competitions = new List<List<string>>() { new List<string> { "HTML", "C#" }, new List<string> { "C#", "Python" }, new List<string> { "Python", "HTML" } };
        List<int> results = new List<int> { 0, 0, 1 };
        var result4 = tournamentWinner.FindTournamentWinner(competitions, results);
        Console.WriteLine(result4);
    }
}