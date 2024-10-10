using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		//double x;
		//double y;
		//public double X
		//{
		//	get
		//	{
		//		return x;

		//	}
		//	set
		//	{
		//		if (value > 200) value = 200;
		//		x = value;
		//	}
		//}
		//public double Y
		//{
		//	get { return y; }
		//	set
		//	{
		//		if (value > 150) y = 150;
		//		y = value;
		//	}
		//}
		//public double GetX() { return x; }
		//public double GetY() { return y; }
		//public void SetX(double x) { 
		//	if(x>200)x=200;
		//	this.x = x; }
		//public void SetY(double y) {
		//	if (y > 150) y = 150;
		//	this.y = y; }
		public double X { get; set; }
		public double Y { get; set; }
		public double distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distanse = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distanse;
		}
		public double distance (Point A, Point B )
		{
			double distance_x = A.X - B.X;
			double distance_y = A.Y - B.Y;
			double distance = Math.Sqrt(distance_x * distance_x + distance_y * distance_y);
			return distance;
		}
		public void Print()
		{
			Console.WriteLine($"X={X}\tY={Y}");
		}

	}
}
