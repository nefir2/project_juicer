using juicer_kateassy.Classes;
using juicer_kateassy.Interfaces;
using juicer_kateassy.Classes.Fruits;

namespace juicer_kateassy
{
	/// <summary>
	/// класс точки входа.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// метод точки входа.
		/// </summary>
		// /// <param name="args">параметры консоли.</param>
		private static void Main() => new MyJucier().MakeJuice(new IFruit[] { new Lemon(), new Apple(Apple.Colors.Green), new Banana(), new Apple(), new Orange(), new Orange(), new Banana(), new Lemon() });
	}
}