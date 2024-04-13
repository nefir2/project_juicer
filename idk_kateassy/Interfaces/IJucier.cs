namespace idk_kateassy.Interfaces
{
	/// <summary>
	/// соковыжималка
	/// </summary>
	public interface IJucier
	{
		/// <summary>
		/// вывод информации каждого элемента массива,<br/>
		/// общее количество, количество цитрусовых, количество яблок.
		/// </summary>
		/// <param name="array">массив фруктов для соковыжималки.</param>
		void MakeJuice(IFruit[] array);
	}
}
