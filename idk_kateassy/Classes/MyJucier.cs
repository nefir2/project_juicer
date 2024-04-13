using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				Console.WriteLine(array[i]);
				//if (!(i == array.Length - 1)) Console.Write(", ");
				//else Console.WriteLine();
                if (array[i].IsCitrus()) citrusCount++;
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
