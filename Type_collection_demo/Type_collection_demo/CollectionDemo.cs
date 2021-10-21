using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_collection_demo
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            #region array
            //datatype[] name = new datatype[size];
            /* int[] numberArray = new int[3];
             numberArray[0] = 454;
             numberArray[1] = 102;
             numberArray[2] = 23;

             for (int i = 0; i < numberArray.Length; i++)
             {
                 Console.WriteLine(numberArray[i]);
             }
            */
            #endregion array
            #region system.collection classes

            /*ArrayList countryList = new ArrayList();
            countryList.Add("India");
            countryList.Add("USA");
            countryList.Insert(1, "france");

            countryList.Add(100);
            countryList.Add(true);

            //object initializer
            Person person = new Person() { FirstName = "Pooja", LastName = "kanvate" };
            
            Console.WriteLine(person.FirstName + "" + person.LastName);
            Console.WriteLine("______________\n");
            countryList.Add(person);



            Console.WriteLine(((Person)countryList[5]).FirstName);

            Console.WriteLine("----------------");
            for (int i = 0; i < countryList.Count; i++)
            {
                Console.WriteLine(countryList[i]);
            }
            */
            #endregion
            #region Generic collection

            /* List<string> countryList = new List<string>();
             countryList.Add("India");
             //countryList.Add(100);



             List<int> numbers = new List<int>();
             numbers.Add(100);



             List<Person> personList = new List<Person>();
             personList.Add(new Person() { FirstName = "aditi", LastName = "godse" });



             Console.WriteLine(personList[0].FirstName);

             */


            #endregion

            #region nullable
            // int i = null;

            Nullable<int> x = null;
            x = 100;
            x = null;

            //datatype?         -----numllable type
            int? y = null;

            #endregion


        }
    }
}
