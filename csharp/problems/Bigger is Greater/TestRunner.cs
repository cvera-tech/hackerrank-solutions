namespace Problems.BiggerIsGreater;

public class TestRunner : TestRunnerBase<Arguments, Solution, string>
{
    public TestRunner()
    {
        inputs.AddRange([
            new() { w = "ab", expected = "ba" },            // test 0
            new() { w = "bb", expected = "no answer" },     // test 1
            new() { w = "hefg", expected = "hegf" },        // test 2
            new() { w = "dhck", expected = "dhkc" },        // test 3
            new() { w = "dkhc", expected = "hcdk" },        // test 4
            new() { w = "lmno", expected = "lmon" },        // test 5
            new() { w = "dcba", expected = "no answer" },   // test 6
            new() { w = "dcbb", expected = "no answer" },   // test 7
            new() { w = "abdc", expected = "acbd" },        // test 8
            new() { w = "abcd", expected = "abdc" },        // test 9
            new() { w = "fedcbabcd", expected = "fedcbabdc" }   // test 10
        ]);
    }
}