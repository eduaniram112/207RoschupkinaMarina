using System;
namespace vegetables
{
    /// <summary>
    /// Класс ящика с овощами.
    /// </summary>
    public class Box
    {
        /// <value>Вес ящика.</value>
        private double weight;
        /// <value>Цена за кг.</value>
        private double price;
        /// <value>Наименование товара.</value>
        private string name; 

        /// <summary>
        /// Конструктор ящика без параметров.
        /// </summary>
        public Box()
        {
            weight = 0;
            price = 0;
            name = "potato";
        }
        /// <summary>
        /// Класс ящика с параметрами.
        /// </summary>
        /// <param name="boxWeight">Вес ящика.</param>
        /// <param name="boxPrice">Цена за кг.</param>
        /// <param name="VegName">Наименование.</param>
        public Box(double boxWeight, double boxPrice, string VegName)
        {
            weight = boxWeight;
            price = boxPrice;
            name = VegName.ToLower();
        }

        /// <summary>
        /// Метод для вычисления цены за весь ящик.
        /// </summary>
        /// <returns>Цена за ящик.</returns>
        public double BoxPrice() { return weight * price; }

        /// <summary>
        /// Метод для вывода информации про ящик.
        /// </summary>
        /// <returns>строку со всей информацией про ящик.</returns>
        public override string ToString()
        {
            return "вес: " + weight.ToString("0.00") + " цена за кг: " + price.ToString("0.00") + " наименование: " + name;
        }

        /// <value>Возвращает вес ящика.</value>
        public double Weight
        {
            get { return weight; }
        }

        /// <value>Возвращает цену за кг товара в ящике.</value>
        public double Price
        {
            get { return price; }
            set { price = value; } 
        }

        /// <value>Возвращает наименование товара в ящике.</value>
        public string Name
        {
            get { return name; }
        }
    }
}
