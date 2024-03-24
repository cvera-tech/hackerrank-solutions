namespace Problems.Encryption;

public class TestRunner : TestRunnerBase<Arguments, Solution, string>
{
    public TestRunner()
    {
        inputs.AddRange([
            new()
            {
                // test 0
                s = "haveaniceday",
                expected = "hae and via ecy"
            },
            new()
            {
                // test 1
                s = "feedthedog    ",
                expected = "fto ehg ee dd"
            },
            new()
            {
                // test 2
                s = "chillout",
                expected = "clu hlt io"
            }
        ]);
    }
}