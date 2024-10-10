using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point(); 
			//Console.WriteLine($"X={A.GetX()}\tY={A.GetY()}");
			//A.SetX(2000);
			//A.Print();
			//A.SetY(3000);
			A.X = 22;
			A.Y = 33;
			A.Print();

			Point B = new Point();
			B.X = 10;
			B.Y = 20;
			B.Print();

			
			Console.WriteLine($"Расстояние от точки 'A' до точки 'B': {A.distance(B)}");
			Console.WriteLine($"Расстояние от точки 'B' до точки 'A': {B.distance(A)}");
			Console.WriteLine($"Рсстояние между точками 'A' и 'B': {A.distance(A, B)}");
			Console.WriteLine($"Рсстояние между точками 'B' и 'A': {B.distance(A, B)}");
		}
		
	}
}
