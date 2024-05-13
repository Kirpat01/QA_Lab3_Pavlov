//Clothing.cs
using System;
namespace STP_6._2_Cs {
    /**
    * \brief Класс одежды
    */
    public class Clothing {
        //! Название одежды
        protected string title;
        //! Потраченная площадь ткани
        protected float fabricArea;
        //! Стоимость за единицу площади потраченной ткани
        protected float pricePerSquareMeter;

        /**
         * @brief Функция инициализации объекта класса Clothing
         * @param[in] name Название одежды
         * @param[in] area Потраченная площадь ткани
         * @param[in] price Стоимость за единицу площади потраченной ткани
         */
        public void Init(string name, float area, float price) {
            title = name;
            fabricArea = area;
            pricePerSquareMeter = price;
        }

        /**
         * @brief Функция вывода данных
         */
        public void Display() {
            Console.WriteLine("Название изделия: " + title);
            Console.WriteLine("Площадь ткани (м^2): " + fabricArea);
            Console.WriteLine("Цена единицы площади ткани: " + pricePerSquareMeter);
        }

        /**
         * @brief Функция вычисления итоговой стоимости одежды
         * @return Стоимость одежды
         */
        public float CostProduct() { return fabricArea * pricePerSquareMeter; }
    }
}
