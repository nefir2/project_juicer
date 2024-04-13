namespace juicer_kateassy.Classes.AbstractClasses
{
	/// <summary>
	/// абстрактный класс, представляющий цитрусовые фрукты.
	/// </summary>
	public abstract class Citrus
	{
		#region fields
		/// <summary>
		/// поле указывающее на то, является ли фрукт цитрусовым.
		/// </summary>
		private readonly bool isCitrus;
		#endregion f
		#region constructors
		/// <summary>
		/// конструктор класса цитрусового фрукта.
		/// </summary>
		public Citrus() => isCitrus = true;
		#endregion ctors
		#region methods
		/// <summary>
		/// возвращает значение в зависимости от того, является ли фрукт цитрусовым.
		/// </summary>
		/// <returns>возвращает <see langword="true"/> если фрукт цитрусовый, иначе <see langword="false"/>.</returns>
		protected bool IsCitrus() => isCitrus;
		#endregion metds
	}
}