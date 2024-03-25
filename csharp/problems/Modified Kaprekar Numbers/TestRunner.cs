namespace Problems.ModifiedKaprekarNumbers;

public class TestRunner : TestRunnerBase<Arguments, Solution, string>
{
    public TestRunner()
    {
        inputs.AddRange([
            new() { p = 1, q = 100, expected = "1 9 45 55 99" },            // test 0
            new() { p = 100, q = 300, expected = "297" },     // test 1
            new() { p = 1, q = 99_999, expected = "1 9 45 55 99 297 703 999 2223 2728 4950 5050 7272 7777 9999 17344 22222 77778 82656 95121 99999" },        // test 2
        ]);
    }
}