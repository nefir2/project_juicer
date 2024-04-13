using System;

using idk_kateassy.Classes.AbstractClasses;
using idk_kateassy.Classes.Fruits;
using idk_kateassy.Interfaces;

namespace idk_kateassy.Classes
{
	/// <summary>
	/// класс, реализующий интерфейс соковыжималки.
	/// </summary>
	public class MyJucier : IJucier
	{
		public void MakeJuice(IFruit[] array)
		{
			int citrusCount = 0;
			int appleCount = 0;
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i].ToString());
				if (array[i] is Citrus) citrusCount++;
				if (array[i] is Apple) appleCount++;
			}
			Console.WriteLine(
				$"общее количество фруктов: {array.Length}\n" +
				$"количество цитрусовых: {citrusCount}\n" +
				$"количество яблок: {appleCount}"
			);
		}
	}
}
