using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // stopwatch to get the time taken to complete 
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var employeeList = Employee.GetEmployees();

            // for each employee, do the processing
            foreach (var item in employeeList)
            {
                ProcessEmployee(item);
            }

            // putting a Parallel.ForEach in employee list
            //Parallel.ForEach(employeeList, e => ProcessEmployee(e));

            // process completed
            // stop the watch and print the elapsed time
            watch.Stop();
            Console.WriteLine(string.Format("\nTime taken to complete = {0}s\n",watch.Elapsed.Seconds.ToString()));

            // just printing the result
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(string.Format("{0}'s Calculated Value {1}.",employee.FirstName,employee.CalculatedProperty));
            }
            Console.ReadLine();
        }

        static Random oRandom = new Random();

        static void ProcessEmployee(Employee employee)
        {
            // showing the current thread which the process runs in
            Console.WriteLine(string.Format("{0}'s Calculation Started on Thread {1}.", employee.FirstName, Thread.CurrentThread.ManagedThreadId));
            // to demonstrate a long operation, I am putting a thread sleep 
            Thread.Sleep(5000);
            // getting a random number to make it look nice
            employee.CalculatedProperty = oRandom.Next(0, 10000);
            Console.WriteLine(string.Format("{0}'s Calculation Completed.", 
                employee.FirstName));
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public int CalculatedProperty { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() 
            { 
                new Employee(){EmployeeId=1,FirstName="Jaliya"},
                new Employee(){EmployeeId=2,FirstName="John"},
                new Employee(){EmployeeId=3,FirstName="Jane"}
            };
        }
    }
}
