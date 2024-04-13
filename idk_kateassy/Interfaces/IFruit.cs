using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk_kateassy.Interfaces
{
    public interface IFruit
    {
        /// <summary>
        /// название фрукта.
        /// </summary>
        /// <returns>название фрукта строкового типа.</returns>
        string GetName();
        /// <summary>
        /// цвет фрукта/
        /// </summary>
        /// <returns>цвет фрукта строкового типа.</returns>
        string GetColor();
        /// <summary>
        /// является ли цитрусовым фруктом.
        /// </summary>
        /// <returns>если цитрусовый фрукт: <see langword="true"/>, иначе <see langword="false"/>.</returns>
        bool IsCitrus();
    }
}
