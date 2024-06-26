﻿namespace juicer_kateassy.Interfaces
{
	/// <summary>
	/// интерфейс представляющий фрукт.
	/// </summary>
	public interface IFruit
	{
		/// <summary>
		/// название фрукта.
		/// </summary>
		/// <returns>название фрукта строкового типа.</returns>
		public string GetName();
		/// <summary>
		/// цвет фрукта.
		/// </summary>
		/// <returns>цвет фрукта строкового типа.</returns>
		public string GetColor();
		/// <summary>
		/// является ли цитрусовым фруктом.
		/// </summary>
		/// <returns>если цитрусовый фрукт: <see langword="true"/>, иначе <see langword="false"/>.</returns>
		public bool IsCitrus();
	}
}