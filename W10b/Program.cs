using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10b
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack NewStack = new Stack();
			string response;
			bool Loop = true;
			while (Loop)
			{
				Console.WriteLine("Enter a character:");
				response = Console.ReadLine();
				if (response == "Stop")
					break;
				else
					NewStack.Push(response);
			}
			for (int i = 0; i < NewStack.Count; i++)
			{
				Console.WriteLine(NewStack.Pop());
			}
			Console.ReadLine();
		}
	}
}
