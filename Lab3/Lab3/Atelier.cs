//Atelier.cs
using System;
using STP_6._2_Cs.Properties;

namespace STP_6._2_Cs {
    /**
    * \brief Класс Ателье
    */
    public class Atelier {
        //! Одежда с коэффициентом мастерства
        private Quality first = new Quality();
        //! Одежда
        private Clothing second = new Clothing();
        //! Стоимость Дополнительных вещей
        private float more;

        /**
         * @brief Функция инициализации объекта класса Clothing
         * @param[in] na1 Название первой одежды
         * @param[in] ar1 Площадь потраченой ткани для первой одежды
         * @param[in] pr1 Стоимость единицы площади первой одежды
         * @param[in] na2 Название второй одежды
         * @param[in] ar2 Площадь потраченой ткани для второй одежды
         * @param[in] pr2 Стоимость единицы площади второй одежды
         * @param[in] sk Коэффициент мастерства мастера
         * @param[in] mo Стоимость дополнительных аксесуаров в ателье
         */
        public void Init(string na1, float ar1, float pr1, string na2, float ar2, float pr2, float sk, float mo) {
            first.Init(na1, ar1, pr1, sk);
            second.Init(na2, ar2, pr2);
            more = mo;
        }

        /**
         * @brief Функция вывода данных
         */
        public void Display() {
            first.Display();
            Console.WriteLine("");
            second.Display();
            Console.WriteLine("");
            Console.WriteLine("Общая стоимость дополнительных аксесуаров: " + more);
        }

        /**
         * @brief Функция вычисления итоговой стоимости одежды
         * @return Стоимость всех вещей в Ателье
         * 
         * Данная функция вычисляет итоговую стоимость всех вещей в ателье по формуле: \f$first.CostProduct + second.CostProduct() + more\f$.
         * 
         * Код функции выглядит следубщим образом:
         * \code
         * public float TotalCost() { return first.CostProduct() + second.CostProduct() + more; }
         * \endcode
         *
         * Результат: \image html C:\Users\Kirill\Desktop\Lab3\img\img.png
         */
        public float TotalCost() { return first.CostProduct() + second.CostProduct() + more; }
    }
}
