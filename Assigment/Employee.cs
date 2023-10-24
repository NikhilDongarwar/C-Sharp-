using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
       static int getid = 1941000;
        int id;
        double salary;
        string name;
        double netsalary;
      
        
        public Employee(double salary,string name) {
            id= ++getid;
            this.salary = salary;
            this.name = name;
            Calculate();
            
            
        
        }
        static Employee()
        {
            Console.WriteLine("Sam Limited");
        }
         public double Calculate () 
        {  
            return netsalary= salary-(salary*0.1);
            
        }

        public void  Display()
        {
            Console.WriteLine(value: $"id={id} name= {name} netsalary={netsalary}");
        }
    }
}
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee(100000,"Sam");
            e1.Display();
            Employee e2 = new Employee(20000, "Anu");
            e2.Display();
            
            

            Console.ReadLine();

        }
    }
}
