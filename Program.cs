using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CsharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee No. : ");
            int emp_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string emp_name = Console.ReadLine();
            Console.WriteLine("Enter the Salary : ");
            double emp_salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Designation : ");
            string emp_desg = Console.ReadLine();

            if (String.Equals(emp_desg, "Manager"))
            {
                Employee emp = new Manager { EmpNo = emp_no, EmpName = emp_name, Salary = emp_salary };
                Console.WriteLine(emp.ToString());
            }
            else
            {
                Console.WriteLine("Enter the kilometer : ");
                int km = Convert.ToInt32(Console.ReadLine());
                Employee emp = new MarketingExecutive(km);
                emp.EmpNo = emp_no; emp.EmpName = emp_name; emp.Salary = emp_salary;
                Console.WriteLine(emp.ToString());
            }

            MyStack stack = new MyStack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int x = stack.Pop();
            stack.Push(4);
            int y = stack.Pop();
            stack.Push(5);
            MyStack stack1 = stack.Clone() as MyStack;
            Console.WriteLine("Size of first stack : " + stack);
            Console.WriteLine("Size of second stack after cloning from first : " + stack1);
            Console.ReadKey();
        }
    }
}
