namespace Problems;

public interface IRunnable<TArguments, TReturn> where TArguments : ArgumentsBase<TReturn>
{
    public TReturn Run(TArguments arguments);
}