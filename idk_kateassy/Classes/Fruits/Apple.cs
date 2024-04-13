using idk_kateassy.AbstractClasses;
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
		private string color;
		private string name;
		private bool isCitrus;
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
		bool IFruit.IsCitrus() => isCitrus;
		public override string ToString() => $"name: {this.name}; color: {this.color}; is citrus: {isCitrus}";
	}
}
