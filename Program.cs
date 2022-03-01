using System;
using System.IO;

class Program
{
	static void Main()
	{
		Console.WriteLine("What was the interaction?");
		string desc = Console.ReadLine() ?? "EMPTY";
		Console.WriteLine("With who?");
		string name = Console.ReadLine() ?? "EMPTY";
		Log log = new Log(desc, name);
		Console.WriteLine(log.ToString());

		string path = @".\interlog.txt";
		using (StreamWriter sw = File.AppendText(path))
		{
			sw.WriteLine(log.ToString());
		}
	}
}

class Log
{
	public DateTime time;
	public string description;
	public string name;

	public Log(string description, string name)
	{
		this.time = DateTime.Today;
		this.description = description;
		this.name = name;
	}

	public override string ToString()
	{
		return '[' + this.time.ToString() + ']' + ':' + this.name + ":" + this.description;
	}
}