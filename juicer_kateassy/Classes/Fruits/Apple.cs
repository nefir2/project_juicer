using juicer_kateassy.Classes.AbstractClasses;
using juicer_kateassy.Interfaces;

using System;

namespace juicer_kateassy.Classes.Fruits
{
	/// <summary>
	/// класс, представляющий не цитрусовый фрукт яблоко.
	/// </summary>
	public class Apple : NonCitrus, IFruit
	{
		#region enum
		/// <summary>
		/// перечисление возможных цветов яблок.
		/// </summary>
		public enum Colors { Red, Green }
		#endregion
		#region fields
		/// <summary>
		/// поле указывающее на то, является ли фрукт цитрусовым.
		/// </summary>
		private readonly bool isCitrus;
		#endregion
		#region properties
		/// <summary>
		/// свойство, содержащее возможные цвета яблока в строковом виде.
		/// </summary>
		private string[] StrColors { get; set; } = new string[] { nameof(Colors.Red), nameof(Colors.Green) };
		/// <summary>
		/// свойство, указывающее на то, выбран ли конструктором цвет яблока.
		/// </summary>
		private bool ColorChosed { get; set; } = false;
		/// <summary>
		/// свойство, содержащее цвет фрукта.
		/// </summary>
		public string Color { get; }
		/// <summary>
		/// свойство, содержащее имя фрукта.
		/// </summary>
		public string Name => nameof(Apple);
		#endregion
		#region constructors
		public Apple()
		{
			Color = ColorChoser();
			isCitrus = base.IsCitrus();
		}
		public Apple(Colors color) : this()
		{
			ColorChosed = true;
			Color = color switch { Colors.Red => nameof(Colors.Red), Colors.Green => nameof(Colors.Green), _ => throw new Exception("unreachable exception.") };
		}
		#endregion ctors
		#region methods
		/// <summary>
		/// choses color to apple, if color is not chosed.
		/// </summary>
		/// <returns>chosed color.</returns>
		private string ColorChoser() => !ColorChosed ? StrColors[new Random().Next(StrColors.Length)] : Color;
		#region realizations
		public string GetColor() => Color;

		public string GetName() => Name;
		public new bool IsCitrus() => isCitrus;
		#endregion realiz
		#region overrides
		public override string ToString() => $"name: {this.Name}\tcolor: {this.Color}\tis citrus: {this.isCitrus}";
		#endregion overr
		#endregion metds
	}
}