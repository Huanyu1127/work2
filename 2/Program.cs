using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	internal class Program
	{
		static void Main(string[] args)
		{//靠又對齊倒三角形
			for (int i = 5; 0<i ; i--)
			{
				int whiteSpace = 5 - i;
				string row = new string(' ', whiteSpace) + new string('*', i);
				Console.WriteLine(row);
			}
		}
	}
}
