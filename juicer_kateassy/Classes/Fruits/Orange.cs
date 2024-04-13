using juicer_kateassy.Classes.AbstractClasses;
using juicer_kateassy.Interfaces;

namespace juicer_kateassy.Classes.Fruits
{
	/// <summary>
	/// класс, представляющий цитрусовый фрукт апельсин.
	/// </summary>
	public class Orange : Citrus, IFruit
	{
		#region fields
		/// <summary>
		/// поле, содержащее цвет фрукта.
		/// </summary>
		private readonly string color;
		/// <summary>
		/// поле, содержащее имя фрукта.
		/// </summary>
		private readonly string name;
		/// <summary>
		/// поле указывающее на то, является ли фрукт цитрусовым.
		/// </summary>
		private readonly bool isCitrus;
		#endregion f
		#region properties
		/// <summary>
		/// свойство, возвращающее цвет фрукта.
		/// </summary>
		public string Color => color;
		/// <summary>
		/// свойство, возвращающее имя фрукта.
		/// </summary>
		public string Name => name;
		#endregion proprts
		#region constructors
		/// <summary>
		/// конструктор класса апельсина.
		/// </summary>
		public Orange()
		{
			name = nameof(Orange);
			color = "Orange";
			isCitrus = base.IsCitrus();
		}
		#endregion ctors
		#region methods
		#region realizations
		public string GetColor() => color;

		public string GetName() => name;
		public new bool IsCitrus() => isCitrus;
		#endregion realiz
		#region overrides
		public override string ToString() => $"name: {this.name}\tcolor: {this.color}\tis citrus: {this.isCitrus}";
		#endregion overr
		#endregion metds
	}
}