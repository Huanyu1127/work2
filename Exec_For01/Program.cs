using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//倒星形三角形
			string row = string.Empty;
			for (int i = 5; 0<i ; i--)
			{
				string value=new string('*', i);
				Console.WriteLine(value);
			}
		}
	}
}
