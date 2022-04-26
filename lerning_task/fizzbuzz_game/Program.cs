using System;
using static System.Console;

class Program
{
	static void Main(string[] args)
	{
		int x = 100;

		for (int i = 1; i <= x; i++)
		{
			if ((i % 3 == 0) && (i % 5 == 0))
			{
				Write(" FizzBuzz ");
			}
			else if (i % 5 == 0)
			{
				Write(" Buzz ");
			}
			else if (i % 3 == 0)
			{
				Write(" Fizz ");
			}
			else
			{
				Write($" {i} ");
			}
		}
	}
}