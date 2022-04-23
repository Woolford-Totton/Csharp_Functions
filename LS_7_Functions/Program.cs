#region ""
using System;

namespace LS_7_Functions
{
    class Program
    {
        #endregion
        /*
            Lesson 7 Functions-

            Functions are a very important and useful tool in programming.

            Functions allow you to call lines of code with only the name of the function.
            
            To declare a function you type this:
        
            static void MyFunction()
            {
                //do code here

            
            }

            To call a function in Main simply call the function name

            MyFunction();

            Functions can also return a datatype (int,string,float)
            
            To declare a function as returning a specific type we replace 
            "void" with our datatype as so:

            static int MyIntFunction()
            {
                //do code here
                
                return 1;   // since this function returns a int a whole number must be provided
            
            }


         */

        static void Main(string[] args)
        {
            Outputhello();

            int myInt = 0;

            Console.WriteLine("Here is myInt :"+ myInt.ToString());

            myInt = ReturnFive();

            Console.WriteLine("Here is myInt after function call:" + myInt.ToString());

            Console.ReadLine();
        }

        static void Outputhello()
        {
            Console.WriteLine("I'm being written by function Outputhello!");

            
        }

        static int ReturnFive()
        {
            Console.WriteLine("I return the int value 5!");

            return 5;
        }



        #region ""
    }
}
#endregion
