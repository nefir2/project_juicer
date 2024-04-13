using idk_kateassy.AbstractClasses;
using idk_kateassy.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk_kateassy.Classes.Fruits
{
	internal class Lemon : Citrus, IFruit
	{
		private string color;
		private string name;
		private bool iscitrus;
		public Lemon()
		{
			name = nameof(Lemon);
			color = "yellow";
			iscitrus = base.isCitrus();
		}
		public string getColor() => color;

		public string getName() => name;
		bool IFruit.isCitrus() => iscitrus;
		public override string ToString() => $"name: {this.name}; color: {this.color}; isCitrus: {iscitrus}";
	}
}
