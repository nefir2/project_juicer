﻿using idk_kateassy.Classes.AbstractClasses;
using idk_kateassy.Interfaces;

namespace idk_kateassy.Classes.Fruits
{
	internal class Lemon : Citrus, IFruit
	{
		private readonly string color;
		private readonly string name;
		private readonly bool isCitrus;
		public string Color => color;
		public string Name => name;
		public Lemon()
		{
			name = nameof(Lemon);
			color = "yellow";
			isCitrus = base.IsCitrus();
		}
		public string GetColor() => color;

		public string GetName() => name;
		public new bool IsCitrus() => isCitrus;
		public override string ToString() => $"name: {this.name}\tcolor: {this.color}\tis citrus: {this.isCitrus}";
	}
}
