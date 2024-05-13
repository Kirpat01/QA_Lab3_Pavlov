//Program.cs
using System;
namespace STP_6._2_Cs {
    /**
     * @brief Главный класс проекта с функцией main
     */
    internal class Program {
        /**
         * @brief Функция, являющаяся точкой входа в программу
         */
        public static void Main(string[] args) {
            Atelier atelier = new Atelier();
            atelier.Init("Куртка", 7f, 13f, "Футболка", 3f, 4f, 1.7f, 432.81f);
            atelier.Display();
            Console.WriteLine("\nЦена за все изделия: " + atelier.TotalCost());
        }
    }
}
