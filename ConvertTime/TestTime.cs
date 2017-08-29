using System;

public class TestTime
{
	static void Main()
	{
		Time corrTime = new Time(12,15);
		string time = corrTime;
		Console.WriteLine(time);
		corrTime = (Time) "8:30";
		Console.WriteLine((string) corrTime);
	}
}

