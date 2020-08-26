using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic variables 
            dynamic val1 = "GeeksforGeeks";
            dynamic val2 = 3234;
            dynamic val3 = 32.55;
            dynamic val4 = true;
            //I love my India
            //I Love my mom and Dad
            // Get the actual type of 
            // dynamic variables 
            // Using GetType() method 
            Console.WriteLine("Get the actual type of val1: {0}",
                                      val1.GetType().ToString());

            Console.WriteLine("Get the actual type of val2: {0}",
                                      val2.GetType().ToString());

            Console.WriteLine("Get the actual type of val3: {0}",
                                      val3.GetType().ToString());

            Console.WriteLine("Get the actual type of val4: {0}",
                                      val4.GetType().ToString());
            var a = 'f';
            var b = "GeeksforGeeks";
            var c = 30.67d;
            var d = false;
            var e = 54544;
            //e =Convert.ToInt32("Balu");

            // Display the type 
            Console.WriteLine("Type of 'a' is : {0} ", a.GetType());

            Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            Console.WriteLine("Type of 'd' is : {0} ", d.GetType());

            Console.WriteLine("Type of 'e' is : {0} ", e.GetType());
           // obj = 'string';
            Console.ReadLine();
        }
    }
}
