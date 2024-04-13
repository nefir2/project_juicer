using idk_kateassy.Classes.AbstractClasses;
using idk_kateassy.Interfaces;

using System;

namespace idk_kateassy.Classes.Fruits
{
	internal class Apple : NonCitrus, IFruit
	{
		public enum Colors { Red, Green }
		private readonly string color;
		private readonly bool isCitrus;
		private string[] StrColors { get; set; } = new string[] { "Red", "Green" };
		private bool ColorChosed { get; set; } = false;
		public string Color => color;
		public string Name => nameof(Apple);
		public Apple()
		{
			color = ColorChoser();
			isCitrus = base.IsCitrus();
		}
		public Apple(Colors color) : this()
		{
			ColorChosed = true;
			this.color = color switch { Colors.Red => StrColors[0], Colors.Green => StrColors[1], _ => throw new Exception("unreachable exception.") };
		}
		private string ColorChoser() => !ColorChosed ? StrColors[new Random().Next(StrColors.Length)] : color;
		public string GetColor() => color;

		public string GetName() => Name;
		public new bool IsCitrus() => isCitrus;
		public override string ToString() => $"name: {this.Name}\tcolor: {this.color}\tis citrus: {this.isCitrus}";
	}
}