using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting with VS 15 preview 5, the out variable is scoped to the 
            // current method and can be used in following statements.
            ReturnValue(out int aval);
            Console.WriteLine($"Value is {aval}");

            // Note that even in this case, the variable is scoped to the method,
            // not just to the inner block.
            if (int.TryParse("42", out int val))
            {
                Console.WriteLine($"Parsed value {val}");
            }
            Console.WriteLine($"Value is {val}");

            // Wildcards might become possible in the future - perhaps 
            // I don't care about one of the values. 
            // This doesn't work yet as of VS 15 preview 5.
            //GetValues(out string important, out string *);


        }

        static void ReturnValue(out int x)
        {
            x = 42;
        }

        static void GetValues(out string one, out string two)
        {
            one = "one";
            two = "two";
        }
    }
}
