//Quality.cs
using System;
namespace STP_6._2_Cs.Properties {
    /**
    * \brief Класс качества, наследующийся класс "Одежда"
    */
    public class Quality : Clothing {
        //! Величина качества
        private float skill;

        /**
         * @brief Функция инициализации объекта класса Quality
         * @param[in] name Название одежды
         * @param[in] area Потраченная площадь ткани
         * @param[in] price Стоимость за единицу площади потраченной ткани
         * @param[in] skill Величина качества
         */
        public void Init(string name, float area, float price, float sk) {
            base.Init(name, area, price);
            skill = sk;
        }

        /**
         * @brief Функция вывода данных
         */
        public void Display() {
            Console.WriteLine("Название изделия: " + title);
            Console.WriteLine("Площадь ткани (м^2): " + fabricArea);
            Console.WriteLine("Цена единицы площади ткани: " + pricePerSquareMeter);
            Console.WriteLine("Коэффициент мастерства: " + skill);
        }

        /**
         * @brief Функция вычисления итоговой стоимости одежды
         * @return Стоимость одежды в зависимости от мастерства
         */
        public float CostProduct() { return fabricArea * pricePerSquareMeter * skill; }
    }
}
