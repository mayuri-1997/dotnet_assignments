using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assign
{
    class Program
    {
        static void Main()
        {

        }
    }

    public abstract class Employee
    {
        protected static int lastEmpNo = 0;
        protected string name;
        protected int empno;
        protected short deptno;
        protected decimal basic;
        public abstract decimal Basic
        {
            set;
            get;
        }

        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }

            }
            get
            {
                return name;
            }
        }

        public int EmpNo
        {
            private set
            {
                empno = value;
            }
            get
            {
                return empno;
            }
        }

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
        

        public abstract decimal CalculateNetSalary();

        public Employee(string name = "nothing", decimal basic = 10000, short deptno = 10)
        {
            empno = ++lastEmpNo;
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;

        }
    }



        public class Manager : Employee
        {

            public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }
            protected string designation;
            public string Designation
            {
                set
                {
                    if (value != null)
                    {
                        designation = value;
                    }
                }
                get
                {
                    return designation;
                }
            }
            public override decimal CalculateNetSalary()
            {
                decimal netsal;
                netsal = basic + 4000 + 1000;//BASIC+DA+TA Fixed
                return netsal;
            }

       public Manager(string name = "nothing", decimal basic = 10000, short deptno = 10, string designation="clerk"):base(name,basic,deptno)
        {
            this.designation = designation;

        }
    }

        public class GenralManager : Manager
        {

        public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }

        protected string perks;
            public string Perks
            {
                set
                {
                    perks = value;
                }
                get
                {
                    return perks;
                }
            }

        public GenralManager(string name = "nothing", decimal basic = 10000, short deptno = 10, string designation = "clerk",string perks="noname"):base(name,basic,deptno,designation)
        {
            empno = ++lastEmpNo;
            this.perks = perks;

        }
    }


        public class CEO : Employee
        {
            public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }
            public sealed override decimal CalculateNetSalary()
            {
                decimal netsal;
                netsal = basic + 4000 + 1000;//BASIC+DA+TA Fixed
                return netsal;
            }
        }

        

    }

