using System;
using System.Collections.Generic;

namespace Task03
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
       
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "Passenger " + Name + " " + LastName + " " + Age;
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        public bool IsNewBorn {get; set; }
        public int NumberOfChildren { get; set; }
       
        public override string ToString()
        {
            return "PassengerWithChildren " + Name + " " + LastName + " " + Age + " " + NumberOfChildren + " " + IsNewBorn;
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }

        public void StartServingQueue()
        {
            int flag = -1;

            while (ordinaryQueue.Count > 0 || priorityQueue.Count > 0)
            {
                if (priorityQueue.Count <= 3 && priorityQueue.Count>0)
                {
                    Passenger p = priorityQueue.Dequeue();
                    Console.WriteLine("priority "+p);
                }
                else
                {
                    if (flag == -1 && priorityQueue.Count > 0)
                    {
                        Passenger p = priorityQueue.Dequeue();
                        Console.WriteLine("priority " + p);
                    }
                    else
                    {
                        Passenger p = ordinaryQueue.Dequeue();
                        Console.WriteLine(p);
                    } 
                    
                }
                flag *= -1;
            }

        }
    }

    class MainClass
    {
        public static void Main()
        {
            PassengerQueue pq = new PassengerQueue();
            Console.WriteLine("_________");
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                if (i % 5 == 0)
                {
                    PassengerWithChildren p = new PassengerWithChildren();
                    p.Name = r.Next(100000, 200000).ToString();
                    p.LastName = r.Next(300000, 400000).ToString();
                    p.NumberOfChildren = r.Next(1, 3);
                    p.Age = r.Next(18, 80);
                    p.IsNewBorn = r.Next(100) <= 50 ? true : false;
                    pq.AddToQueue(p);
                }
                else
                {
                    Passenger p = new Passenger();
                    p.Name = r.Next(100000, 200000).ToString();
                    p.LastName = r.Next(300000, 400000).ToString();
                    p.Age = r.Next(18, 80);
                    pq.AddToQueue(p);
                }

            }
            pq.StartServingQueue();
            
        }

    }
}