namespace juicer_kateassy.Classes.AbstractClasses
{
	/// <summary>
	/// абстрактный класс, представляющий не цитрусовые фрукты.
	/// </summary>
	public abstract class NonCitrus
	{
		#region fields
		/// <summary>
		/// поле указывающее на то, является ли фрукт цитрусовым.
		/// </summary>
		private readonly bool isCitrus;
		#endregion f
		#region constructors
		/// <summary>
		/// конструктор класса не цитрусового фрукта.
		/// </summary>
		public NonCitrus() => isCitrus = false;
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