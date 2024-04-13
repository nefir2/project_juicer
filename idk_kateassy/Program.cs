using static idk_kateassy.Program;
using System;
using idk_kateassy.Classes;
using idk_kateassy.Interfaces;
using idk_kateassy.Classes.Fruits;

namespace idk_kateassy
{
	/// <summary>
	/// класс точки входа.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// метод точки входа.
		/// </summary>
		/// <param name="args">параметры консоли.</param>
		private static void Main(string[] args) => new MyJucier().MakeJuice(new IFruit[] { new Lemon(), new Apple(), new Banana(), new Apple(), new Orange(), new Orange(), new Banana(), new Lemon() });
	}
}