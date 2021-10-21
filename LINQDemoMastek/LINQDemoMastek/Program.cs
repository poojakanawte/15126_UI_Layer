using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemoMastek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            /*   int[] numbers = { 44, 434, 345, 45, 67, 890, 987 };

               //declarative
               //print event numbers

             int[] evendata = (from n in numbers where n % 2 == 0 select n).ToArray();

              //evendata = numbers.Where(IsEvenNumber).ToArray();
               //foreach (int item in numbers)

               {

                   if(IsEvenNumber(item))
                   {

                   }
               }

             for (int i = 0; i < evendata.Length; i++)

               {
                   Console.WriteLine(evendata[i]);
               }
             */
            #endregion
            #region List
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });

            #endregion
            #region emplist

            /*  IEnumerable<Employee> Query2 = from e in empList
                                             where e.Dept == "sales"
                                             select e;

              Query2 = empList.Where(e => e.Dept == "sales");

              foreach (Employee item in empList)
              {
                  Console.WriteLine(item);
              }

              */
            #endregion

            #region query
            // list all emps who are earning more then 25000
            /*  IEnumerable<Employee> Query3 = from e in empList
                                              where  e.Salary > 25000
                                              select e;

               Query3 = empList.Where(e => e.Salary > 25000 );

               foreach (Employee item in Query3)
               {
                   Console.WriteLine(item);
               }
            */
            // list all emps whose name begins with p
            //defered execution
            /*  IEnumerable<Employee> query7 = from e in empList
                                             where e.EmpName.StartsWith('p')
                                             select e;
                query7 = empList.Where(e => e.EmpName.StartsWith("p"));
              empList.Add(new Employee() { EmpNo = 201, EmpName = "peter", Address = "pune", Dept = "hr", Salary = 25000 });
              Console.WriteLine("---------Line Query output------");

              foreach (Employee item in query7)
              {
                  Console.WriteLine(item);
              }
              empList.Add(new Employee() { EmpNo = 301, EmpName = "peter1", Address = "pune", Dept = "hr", Salary = 25000 });
              Console.WriteLine("---------Line Query output------");
              foreach (Employee item in query7)
              {
                  Console.WriteLine(item);
              }

              Employee emp = (from e in empList where e.Address == "mumbai" select e).SingleOrDefault();
              Console.WriteLine("Employee:" + emp);

           */
            //annonymous type and var-implicitly type local vaariable
            var query8 = from e in empList select new { e.EmpName,Department= e.Dept, e.Salary  };

            //method syntax
            query8 = empList.Select(e => new { e.EmpName, Department = e.Dept, e.Salary });

            foreach (var item in query8)
            {
                Console.WriteLine(item.EmpName + "  " + item.Department + "  " + item.Salary);
            }

            var query9 = from e in empList where e.Salary > 20000 && e.Salary < 30000 select new { e.EmpName, e.Salary };
            foreach (var item in query9)
            {
                Console.WriteLine(item.EmpName + " " + item.Salary);
            }

            query9 = empList.Where(e => e.Salary >= 20000 && e.Salary <= 30000).Select(e => new { e.EmpName, e.Salary });

            foreach ( var item in query9)
            {
                Console.WriteLine(item.GetType().Name);
            }

            //defered execution
            // list all emps who are staying in mumbai and working for hr dept
            /*   IEnumerable<Employee> query6 = empList.Where(e => e.Address == "mumbai" && e.Dept == "hr");

                query6 = empList.Where(e => e.Address == "mumbai" && e.Dept == "hr");



                foreach (Employee item in query6)
                 {



                    Console.WriteLine(item);
                }


            */
            #endregion
        }
    }
}
