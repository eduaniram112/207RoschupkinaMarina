using System;
using System.Collections.Generic;

namespace vegetables
{
    /// <summary>
    /// Класс склада.
    /// </summary>
    public class Warehouse
    {
        /// <value>Максимальная вместимость склада в контейнерах.</value>
        private int maxCapacity;
        /// <value>Список контейнеров на складе..</value>
        List<Container> Containers;
        /// <value>Плата за хранение контейнера на складе.</value>
        private double charge;

        /// <summary>
        /// Констуктор склада без параметров.
        /// </summary>
        public Warehouse()
        {
            maxCapacity = 0 ;
            Containers = new List<Container>();
            charge = 0;
        }

        /// <summary>
        /// Конструктор склада с параметрами.
        /// </summary>
        /// <param name="warehouseCapacity">Максимальная вместимость склада.</param>
        /// <param name="newcharge">Плата за хранение.</param>
        public Warehouse(int warehouseCapacity, double newcharge)
        {
            maxCapacity = warehouseCapacity;
            Containers = new List<Container>();
            charge = newcharge;
        }

        /// <summary>
        /// Метод, добавляющий новый контейнер на склад.
        /// </summary>
        /// <param name="newContainer">Контейнер, который надо добавить.</param>
        public void AddToWarehouse(Container newContainer)
        {
            //Рассчет повреждения контейнера.
            Random r = new Random();
            double damage = r.Next(0, 5) / 10;

            //Проверка на то, выгодно ли нам вообще его хранить.
            if (newContainer.WorthIt(damage, charge))
            {
                //Если он влезает, то просто добавляем.
                if (Containers.Count < maxCapacity)
                {
                    Containers.Add(newContainer);
                }

                //Если не влезает, то удаляем самый старый контейнер.
                else
                {
                    Console.WriteLine("Кончилось место, поэтому удаляем следующий контейнер \n" + Containers[0]);
                    Containers.RemoveAt(0);
                    Containers.Add(newContainer);
                }
            }
            else
            {
                Console.WriteLine("Хранить контейнер невыгодно, поэтому делать мы этого не будем");

            }

        }
        /// <summary>
        /// Метод, удаляющий котейнер со склада.
        /// </summary>
        /// <param name="number">Номер контейнера, который надо удалить.</param>
        public void RemoveFromWarehouse(int number)
        {   if (number > 0 && number < Containers.Count)
            {
                Console.WriteLine("Удален следующий контейнер \n" + Containers[number]);
                Containers.RemoveAt(number);
            }
            else
            {
                Console.WriteLine("Контейнера с таким номером нет");
            }
        }

        /// <summary>
        /// Метод для вывода информации про склад.
        /// </summary>
        /// <returns>строку со всей информацией про склад.</returns>>
        public override string ToString()
        {
            string str = "максимальная вместимость: " + maxCapacity + " занято: " + Containers.Count + " плата за хранение: " + charge.ToString("0.00");
            return str;
        }
        /// <summary>
        /// Метод для вывода списка контейнеров.
        /// </summary>
        public void ListofContainers()
        {
            for (int i = 0; i < Containers.Count; i++)
            {
                Console.WriteLine(Containers[i]);
            }
        }

        /// <summary>
        /// Ищет овощ на складе по его названию.
        /// </summary>
        /// <param name="vegetable">Наименование овоща, который надо найти.</param>
        /// <returns>True если овощ найден и False если нет.</returns>
        public bool FindVegetable(string vegetable)
        {
            bool flag = false;
            for (int i = 0; i < Containers.Count; i++)
            {
                List<Box> myBoxes = Containers[i].GetBoxes();
                for (int j = 0; j < myBoxes.Count; j++)
                {
                    if (myBoxes[j].Name == vegetable) flag = true;

                }

            }
            return flag;

        }










        /// <summary>
        /// Секретный протокол.
        /// Больше ничего не скажу.
        /// </summary>
        public void OlivieProtocol()
        {
            if (FindVegetable("potato") && FindVegetable("carrot") && FindVegetable("pea") && FindVegetable("cucumber"))
            {
                Console.WriteLine("На складе есть все для оливье");
            }
            else
            {
                Console.WriteLine("На складе не хватает овощей для оливье");
                Console.WriteLine("Для оливье нужны: potato, carrot, cucumber, pea");
            }
        }
    }
}
