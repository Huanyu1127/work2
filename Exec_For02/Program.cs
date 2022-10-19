using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//等腰星形三角形 空白+星星 +1+1   底n顆星 n必奇數 i=n/2進位
			//for(int i = 3; i <=5 ; i++)
			//{
			//	//int sum = i; //一排總和
			//	//int whiteSpaceCount = 5 - sum;
			//	//int starCount = sum - whiteSpaceCount;
			//	//string row=new string(' ', whiteSpaceCount) +new string('*', starCount);
			//	//Console.WriteLine(row);

			//}

			// 底2i+1個星星
			int starCount = 1;
			for(int i = 2; 0 <= i; i--)
			{
				int whiteSpace = i;
				string row=new string(' ', whiteSpace)+new string('*', starCount);
				Console.WriteLine(row);
				starCount = starCount + 2;
			}
		}
	}
}
