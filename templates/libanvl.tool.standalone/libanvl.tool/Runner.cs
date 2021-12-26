namespace libanvl.tool;

/// <summary>
/// Represents the core implementation of the tool.
/// </summary>
public class Runner
{
    /// <summary>
    /// Runs the core implementation of the tool.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    /// <returns>The tool return code.</returns>
	public async ValueTask<int> RunAsync(string[] args)
	{
        await Console.Out.WriteLineAsync("Tool Greeting");
        return 0;
	}
}
