/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    class Program
    {
        static void Main()
        {
            // Iteration Statements:
            /* C# enables a sequence of statements to execute repeatedly
             with the while, do-while, for, and foreach statements. */

            // While and do-while loops:
            /* While loops repeatedly execute a body of code while a 
             bool expression is true. The expression is tested BEFORE
             the body of the loop is executed. For example: */
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
            /* OUTPUT:
             0
             1
             2 */
            /* Do-while loops differ in functionality from while loops
             only in that they test the expression AFTER the statement
             block has executed (ensuring that the block is always 
             executed at least once). Here's the preceding example
             rewritten with a do-while loop: */
            int I = 0;
            do
            {
                Console.WriteLine(I);
                i++;
            }
            while (I < 3);

            // For loops
            /* For loops are like while loops with special clauses
             for initialization and iteration of a loop variable.
             A for loop contains three clauses as follows:
             for (initialization-clause; condition-clause; iteration-clause)
                statement-or-statement-block;
             -Iteration clause:
                Executed before the loop begins; used to initialize one or 
                more iteration variables.
             -Condition clause:
                The bool expression that, while true, will execute the body.
             -Iteration clause:
                Executed AFTER each iteration of the statement block; used
                typically to update the iteration variable.
             For example, the following prints the numbers 0 thru 2:  */
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(j);
            }
            /* The following prints the first 10 Fibonacci numbers (where 
             each number is the sum of the previous two): */
            for (int J = 0, prevFib = 1, curFib = 1; J < 10; J++)
            {
                Console.WriteLine(prevFib);
                int newFib = prevFib + curFib;
                prevFib = curFib; curFib = newFib;
            }
            /* Any of the three parts of the for statment may be omitted.
             One can implement an infinite loop such as the following
             (though while(true) may be used instead):
             for (;;)
                Console.WriteLine("Interrupt me"); */

            //Foreach loops
            /* The foreach statement iterates over each element in an 
             enumerable object. Most of the types in C# and the .NET
             framework that represent a set of list of elements are 
             enumerable. For example, both an array and a string are 
             enumerable. Here is an example of enumerating over the 
             characters in a string, from the first character thru
             to the last: */
            foreach (char c in "deer") // c is the iteration variable
                Console.WriteLine(c);
            /*OUTPUT:
             d
             e
             e
             r */
        }
    }
}
