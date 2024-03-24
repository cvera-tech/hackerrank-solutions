namespace Problems;

public abstract class TestRunnerBase<TArguments, TRunnable, TResult> 
    where TRunnable : IRunnable<TArguments, TResult>, new() 
    where TArguments : ArgumentsBase<TResult>
{
    protected readonly List<TArguments> inputs = [];
    public void RunTests(int testNumber = -1)
    {
        if (testNumber >= 0)
            RunTest(testNumber);
        else
            for (int index = 0; index < inputs.Count; index++)
                RunTest(index);
    }

    private void RunTest(int testNumber)
    {
        string outputString = $"{testNumber}: ";
        try
        {
            TResult result = new TRunnable().Run(inputs[testNumber]);
            if (CheckResult(result, inputs[testNumber].expected))
                outputString += "Success 🎉";
            else
                outputString += $"Failure 😵 => returned {result}; expected {inputs[testNumber].expected}";
            Console.WriteLine(outputString);
        }
        catch (Exception)
        {
            Console.WriteLine("RUNTIME ERROR 💩");
            throw;
        }
    }

    protected virtual bool CheckResult(TResult result, TResult expected)
    {
        return result!.Equals(expected);
    }
}