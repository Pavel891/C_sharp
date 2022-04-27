using System;
using static System.Console;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace wake_up_neo
{
	class Program
	{
		static void Write_frace(string words)
		{
			foreach (char i in words)
			{
				Thread.Sleep(90);
				Write(i);
			}
			Thread.Sleep(4000);
			Console.Clear();
		}
		static void Main(string[] args)
		{
			ForegroundColor = ConsoleColor.Green;
			string s1 = "Wake up Neo...";
			string s2 = "Matrix has you...";
			string s3 = "Follow the white rabbit...";

			Write_frace(s1);
			Write_frace(s2);
			Write_frace(s3);
		}
	}
}