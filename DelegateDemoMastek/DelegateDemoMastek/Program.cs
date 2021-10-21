using System;

namespace DelegateDemoMastek
{
    delegate int CalculatorDelegate(int first, int second);
    class Program
    {

       /* static int MulNumbers(int number1,int number2)
        {
            return number1 * number2;
        }
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
       */

        static void Main(string[] args)
        {


            int result;

            //int result1 = demo2(5, 6);
           
           
            Console.WriteLine("-----------");

            CalculatorDelegate demo2 = (a, b) => a + b;
            result = demo2(12, 5);
            Console.WriteLine("addition" + result);
            

            CalculatorDelegate demo3 = (a, b) => a - b;
            result = demo3(12, 5);
            Console.WriteLine("Substraction" + result);
          

            CalculatorDelegate demo4 = (a, b) => a % b;
            result = demo4(12, 5);
            Console.WriteLine("Division" + result);



            CalculatorDelegate demo5 = (a, b) => a * b;
            result = demo5(12, 5);
            Console.WriteLine("Multiplication" + result);









        }
    }
}
