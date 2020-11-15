using System;
using System.Collections.Generic;

namespace vegetables
{
    /// <summary>
    /// Класс контейнера с ящиками.
    /// </summary>
    public class Container
    {
        /// <value>Максимальная вместимость контейнера в кг.</value>
        private int maxCapacity;
        /// <value>Список ящиков.</value>
        List<Box> Boxes;
        /// <summary>
        /// Конструктор контейнера.
        /// </summary>
        public Container()
        {
            Random r = new Random();
            //Рандомно задаем максимальную вместимость.
            maxCapacity = r.Next(50, 1001);
            Boxes = new List<Box>();
        }

        /// <summary>
        /// Метод, добавляющий ящик в контейнер.
        /// </summary>
        /// <param name="newBox">Новый ящик.</param>
        public void AddToContainer(Box newBox)
        {
            Random r = new Random();
            
            //Проверяем, влезает ли ящик.
            if (newBox.Weight + CurrentCapacity() <= maxCapacity)
            {
                Boxes.Add(newBox);
            }
            else
            {
                Console.WriteLine("Ящик не влезает");
            }

        }
        /// <returns>Возвращает список всех коробок.</returns>
        public List<Box> GetBoxes()
        {
            return Boxes;
        }

        /// <returns>Возвращает общую стоимость содержимого контейнера.</returns>
        public double ContainerPrice()
        {
            double conPrice = 0;
            foreach (Box b in Boxes)
            {
                conPrice += b.BoxPrice();
            }
            return conPrice;
        }

        /// <summary>
        /// Метод для вывода информации про контейнер.
        /// </summary>
        /// <returns>строку со всей информацией про контейнер.</returns>>
        public override string ToString()
        {
            string str = "максимальная вместимость: " + maxCapacity + " занято: " + CurrentCapacity().ToString("0.00") + " ящиков: " + Boxes.Count;
            return str;
        }

        /// <summary>
        /// Метод, рассчитывающий выгодно ли хранить контейнер на складе.
        /// </summary>
        /// <param name="damage">повреждение</param>
        /// <param name="charge">плата за хранение</param>
        /// <returns>True если выгодно и False если не выгодно.</returns>
        public bool WorthIt(double damage, double charge)
        {
            double newPrice = ContainerPrice() - damage*Boxes.Count;
            if (newPrice > charge) return true;
            else return false;
        }
        /// <summary>
        /// Метод для вывода списка ящиков.
        /// </summary>
        public void ListofBoxes()
        {
            for (int i = 0; i < Boxes.Count; i++)
            {
                Console.WriteLine(Boxes[i]);
            }
        }
        
        /// <returns>Возвращает текущую заполненность контейнера.</returns>
        public double CurrentCapacity()
        {
            double curCap = 0;
            for (int i = 0; i < Boxes.Count; i++)
            {
                curCap += Boxes[i].Weight;
            }
            return curCap;
        }
    }
}
