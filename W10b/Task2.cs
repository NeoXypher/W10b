using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10b
{
	class Task2
	{
		public static void Main()
		{
			Stack NewStack = new Stack();
			string response;
			bool Loop = true, Balanced = true;
			while (Loop)
			{
				Console.WriteLine("Enter a character:");
				response = Console.ReadLine();
				if (response == "Stop")
					break;
				else if (response == "{" || response == "[" || response == "(")
				{
					NewStack.Push(response);
					Balanced = false;
				}
				else if ((response == "}" && Convert.ToString(NewStack.Peek()) == "{") || (response == ")" && Convert.ToString(NewStack.Peek()) == "(") || (response == "]" && Convert.ToString(NewStack.Peek()) == "["))
				{
					NewStack.Pop();
					if (NewStack.Count == 0)
						Balanced = true;
				}
							
			}
			Console.WriteLine(Balanced);
			Console.ReadLine();
		}
	}
}
