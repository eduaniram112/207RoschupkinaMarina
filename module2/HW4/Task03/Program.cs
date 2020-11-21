using System;
using System.Collections.Generic;

namespace Task03
{
    class TestOverride
    {
        public class Employee : IComparable<Employee>
        {
            public string name;


            protected decimal basepay;


            public Employee(string name, decimal basepay)
            {
                this.name = name;
                this.basepay = basepay;
            }

            public virtual decimal CalculatePay()
            {
                return basepay;
            }

            public int CompareTo(Employee p)
            {
                return this.CalculatePay().CompareTo(p.CalculatePay());
            }

            public override string ToString()
            {
                return "name: "+name + " basepay: " + basepay;
            }

        }


        public class SalesEmployee : Employee
        {
  
            private decimal salesbonus;


            public SalesEmployee(string name, decimal basepay,
                      decimal salesbonus) : base(name, basepay)
            {
                this.salesbonus = salesbonus;
            }

            public override decimal CalculatePay()
            {
                return basepay + salesbonus;
            }
            public override string ToString()
            {
                return base.ToString()+" salesbonus: "+salesbonus + " total pay: "+CalculatePay();
            }
        }

        public class PartTimeEmployee : Employee
        {


            private decimal workingDays;


            public PartTimeEmployee(string name, decimal basepay, decimal workingDays) : base(name, basepay)
            {
                this.workingDays = workingDays;
            }

            public override decimal CalculatePay()
            {
                return basepay/25 * workingDays;
            }
            public override string ToString()
            {
                return base.ToString() + " working days: " + workingDays + " total pay: " + CalculatePay();
            }
        }

        static void Main()
        {
            Employee[] emp = new Employee[10];
            Random r = new Random();
            int inds = 0, indp = 0;
            for (int i = 0; i < emp.Length; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    inds++;
                    emp[i] = new SalesEmployee("saler " + inds, r.Next(20, 101), r.Next(0, 20));
                }
                else
                {
                    indp++;
                    emp[i] = new PartTimeEmployee("part time worker " + indp, r.Next(20, 101), r.Next(1, 60));
                }
                Console.WriteLine(emp[i]);
            }
            Console.WriteLine();
            Array.Sort(emp);
            foreach (Employee e in emp)
            {
                Console.WriteLine(e);
            }
        }
    }
    
}
