# C# Problems

Each problem has its own namespace of the format
```
Problems.<name of problem>
```

The `Problems` namespace contains classes that can be used to easily test solutions against inputs. When creating a new folder, create classes deriving/implementing the following:
* `ArgumentsBase` - This class contains all inputs as well as the correct output.
* `IRunnable` - This interface declares the `Run` method that takes the inputs in `ArgumentsBase` and returns an output. All solution classes should implement this interface.
* `TestRunnerBase` - This class runs the test cases and compares the outputs to the correct results. By default, it calls the `Equals` method to make the comparison, but this behavior can be changed by overriding its `CheckResults` method.