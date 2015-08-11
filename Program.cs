using static System.Console;
using Microsoft.Framework.Runtime;

public class Program
{
	public Program(IApplicationEnvironment env)
	{
		WriteLine("Class Program created!");
		WriteLine(env.ApplicationName);
		WriteLine(env.Version);
		WriteLine(env.RuntimeFramework.FullName);
	}
	
	public void Main()
	{
		WriteLine("Hello .NET World!");
	}
}