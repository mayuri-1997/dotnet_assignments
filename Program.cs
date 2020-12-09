using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_assign
{
    class Program
    {
        
    }

    class Employee
    {
        private static int lastEmpNo = 0;
        private string name;
        public string Name
        {
            set
            {
                if(value != null)
                {
                    name = value;
                }

            }
            get
            {
                return name;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 10 && value < 123450)
                {
                    basic = value;
                }
                else
                    Console.WriteLine("Basic must be in range 10 to 50 ");



            }
            get
            {
                return basic;
            }
        }
        private short deptno;
        public short DeptNo
        {
            set
            {
                if (value > 0 && value < 127)
                {
                    deptno = value;
                }
                else
                    Console.WriteLine("Dept No must be grater than 0 and less than 128");
            }
            get
            {
                return deptno;
            }

        }
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
            private set
            {
                empNo = value;
            }
        }

        //Methods
        public decimal getNetSalary()
        {
            decimal netsal;
            netsal = basic + 4000 + 1000;//BASIC+DA+TA Fixed
            return netsal;
        }


        Employee(string name="nothing",decimal basic=10000,short deptno=10)
        {
            empNo = ++lastEmpNo;
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;

        }

        static void Main()
        {
            Employee e = new Employee();
            Console.WriteLine(e.empNo);
            Employee e1 = new Employee();
            Console.WriteLine(e1.empNo);
            Console.WriteLine(e.getNetSalary());
            Console.ReadLine();
            

        }
    }
}
