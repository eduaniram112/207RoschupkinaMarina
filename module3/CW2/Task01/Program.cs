using System;

namespace Task01
{
    class Person
    {
        public string Name { get; set; }
    }
    class Client : Person { }
    delegate Person PersonFactory(string name);
    delegate void ClientInfo(Client client);



    class Program
    {
        static void Main(string[] args)
        {
            PersonFactory personDel;
            personDel = BuildClient;
            Person p = personDel("A");
            Console.WriteLine(p.Name);
            ClientInfo clientInfo = GetPersonInfo;
            Client client = new Client { Name = "B" };
            clientInfo(client);
        }
        public static void GetPersonInfo(Person p)
        {
            Console.WriteLine(p.Name);
        }
        public static Client BuildClient(string name)
        {
            return new Client { Name = name };
        }
    }
}
