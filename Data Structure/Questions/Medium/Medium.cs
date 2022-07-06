using AlgoExpert;

public class Medium : Questions
{
    public override void Execute()
    {
        /* 1. ThreeNumberSum */
        var array1 = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
        var targetSum1 = 0;
        var result1 = ThreeNumberSum.ThreeNumberSumSolutionOne(array1, targetSum1);
        PrintListArray(result1);
        var result2 = ThreeNumberSum.ThreeNumberSumSolutionTwo(array1, targetSum1);
        PrintListArray(result2);
    }
}