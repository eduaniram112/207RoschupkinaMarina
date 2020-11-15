using System;
/*
 Реализовать класс, представляющий сведения о человеке Person.
Реализовать свойства: Ф.И.О.(string FullName), дата рождения (DateTime BirthDate), пол (bool IsMale).
Реализовать метод для вывода информации о человеке void ShowInfo().
Реализовать класс, представляющий сведения о студенте Student (наследуется от Person).
Реализовать свойства: название ВУЗа (string Institute), специальность (string Speciality).
Реализовать класс, представляющий сведения о сотруднике фирмы Employee (наследуется от Person).
Реализовать свойства: название компании (string CompanyName), должность (string Post), график (string Schedule),
оклад (decimal Salary).
 
В основной программе решить задачи:
- Создать  объекты всех трех типов и вызвать ShowInfo(), чтобы показать всю доступную информацию.
- Создать массив Person[] arr и присвоить его членам объекты всех трех типов. Продемонстрировать работу метода ShowInfo() на массиве. 
 */

class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }

    public Person(string f, DateTime d, bool m)
    {
        FullName = f;
        BirthDate = d;
        IsMale = m;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale}");
    }
}

class Student : Person
{
    public string Institute { get; set; }
    public string Speciality { get; set; }

    public Student(string f, DateTime d, bool m, string inst, string spec) : base(f, d, m)
    {
        Institute = inst;
        Speciality = spec;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Institute} {Speciality}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public string Post { get; set; }
    public string Schedule { get; set; }
    public decimal Salary { get; set; }

    public Employee(string f, DateTime d, bool m, string com, string pos,string sch,decimal sal) : base(f, d, m)
    {
        Company = com;
        Post = pos;
        Schedule = sch;
        Salary = sal;

    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Company} {Post} {Schedule} {Salary}  ");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("ewfewfef", new DateTime(2000, 10, 10), true);
        Student student = new Student("oieweqvb", new DateTime(2010, 5, 5), false, "3grh4", "r4tgrv");
        person.ShowInfo();
        student.ShowInfo();
        Employee rabotnichek = new Employee("Dolly Parton", new DateTime(2000, 11, 11), false, "yeet", "manager", "9 to 5", 10000);
        rabotnichek.ShowInfo();
        Person[] arr = new Person[3];
        arr[0] = person;
        arr[1] = student;
        arr[2] = rabotnichek;
        foreach (Person a in arr)
        {
            a.ShowInfo();
        }

    }
}