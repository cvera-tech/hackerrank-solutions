namespace Problems.HalloweenSale;

public class TestRunner : TestRunnerBase<Arguments, Solution, int>
{
    public TestRunner()
    {
        inputs.AddRange([
            new() { p = 20, d = 3, m = 6, s = 80, expected = 6 },   // test 0
            new() { p = 20, d = 3, m = 6, s = 85, expected = 7 },   // test 1
            new() { p = 100, d = 1, m = 1, s = 99, expected = 0},   // test 2
        ]);
    }
}