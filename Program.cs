using static System.Console;
using Microsoft.Framework.Runtime;

public class Program
{
	private readonly IApplicationEnvironment _env;
	
	public Program(IApplicationEnvironment env)
	{
		_env = env;
	}
	
	public void Main()
	{
		WriteLine("Hello .NET World!");
		
		WriteLine($"App: {_env.ApplicationName}");
		WriteLine($"Version: {_env.Version}");
		WriteLine($"Framework: {_env.RuntimeFramework.FullName}");
	}
}