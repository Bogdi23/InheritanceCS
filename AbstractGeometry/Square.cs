using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square : Shape
	{
		double side;
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public Square
			(
			double side, int startX, int startY, 
			int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Side = side;
		}
		public override double GetArea() => Side * Side;
		public override double GetPerimeter() => 4 * Side;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Side, (float)Side);
			e.Graphics.FillRectangle(brush, StartX, StartY, (float)Side, (float)Side);
		}
		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Сторона: {Side}");
			base.Info(e);
		}
	}
}
