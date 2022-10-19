using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//右側對齊星形三角形
			
			for(int i = 1; i<=5 ; i++)
			{
				int whiteSpace = 5 - i;
				string row=new string(' ',whiteSpace) + new string('*', i);
				Console.WriteLine(row);
			}
			//靠右對齊倒三角形
			//for (int i = 5; 0 < i; i--)

		}
	}
}
