namespace AlgoExpert;

class Program
{
    static void Main(string[] args)
    {
        /*Simple Question*/
        Simple simple = new Simple();
        simple.Execute();
        /*Medium Question*/
        Medium medium = new Medium();
        medium.Execute();
        /*Hard Question*/
        Hard hard = new Hard();
        hard.Execute();
        /*Very Hard Question*/
        VeryHard veryHard = new VeryHard();
        simple.Execute();
    }
}