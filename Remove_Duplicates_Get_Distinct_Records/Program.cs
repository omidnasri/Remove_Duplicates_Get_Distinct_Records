using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_Get_Distinct_Records
{
    class Program
    {
        //How to Remove Duplicates and Get Distinct records from List using LINQ ?
        public static void Main(string[] args)
        {
            // Example 1:
            {
                List<Employee> employees = new List<Employee>() {
                    new Employee { EmpID = 1 , Name ="AC"},
                    new Employee { EmpID = 2 , Name ="Peter"},
                    new Employee { EmpID = 3 , Name ="Michael"},
                    new Employee { EmpID = 3 , Name ="Michael"}
                };
                var DistinctItems = employees.GroupBy(x => x.EmpID).Select(y => y.First());
                foreach (var item in DistinctItems)
                    Console.WriteLine(item.Name);
            }
            //
            // Example 2:
            {
                List<Employee> employees2 = new List<Employee>(){
                    new Employee{EmpID =1,Name="AAAAA"}
                   , new Employee{EmpID =2,Name="BBBBB"}
                   , new Employee{EmpID =3,Name="AAAAA"}
                   , new Employee{EmpID =4,Name="CCCCC"}
                   , new Employee{EmpID =5,Name="AAAAA"}
                };
                List<Employee> duplicateEmployees = employees2.Except(employees2.GroupBy(i => i.Name).Select(ss => ss.First())).ToList();
                foreach (var item in duplicateEmployees)
                    Console.WriteLine("\t" + item.Name);
            }
            Console.ReadLine();
        }
    }
    public class Employee

    {

        public string Name { get; set; }

        public int EmpID { get; set; }

    }
}