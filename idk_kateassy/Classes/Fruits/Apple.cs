using idk_kateassy.Classes.AbstractClasses;
using idk_kateassy.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk_kateassy.Classes.Fruits
{
	internal class Apple : NonCitrus, IFruit
	{
		private readonly string color;
		private readonly string name;
		private readonly bool isCitrus;
		public string Color => color;
		public string Name => name;
		public Apple()
		{
			Random rnd = new Random();
			string[] colors = new string[] { "Red", "Green" };

			name = nameof(Apple);
			color = colors[rnd.Next(colors.Length)];
			isCitrus = base.IsCitrus();
		}
		public string GetColor() => color;

		public string GetName() => name;
		public new bool IsCitrus() => isCitrus;
		//public override string ToString() => $"{"name: " + this.name, 15}; {"color:" + this.color, 15}; {"is citrus:" + this.isCitrus, 15}";
		public override string ToString() => $"name: {this.name}\tcolor: {this.color}\tis citrus: {this.isCitrus}";
	}
}
