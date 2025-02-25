using System;

namespace DeclaringBools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring Bools, strings, lists, and numbers

            // BOOL - can have a value of either true or false

            bool isTrue = false; // you can set the value of a variable upon declaring it

            bool? isFalse; // you can also leave it undefined; 

            isTrue = true; // you can change or set the value of a variable after declaring it

            isFalse = null; // you can also set it to null


            isFalse = !isTrue; // the logical negation operator (!) treats the bool as the opposite of its value; in this case, isTrue is set to true, so the ! will treat it as false
            // if isTrue were set to false, it would be treated as true in this context
            // the ! doesn't change the value in the isTrue variable but changes how it is treated in this context
            // isFalse will be set to false here.


            Console.WriteLine("isTrue is " + isTrue);
            Console.WriteLine($"isFalse is {isFalse}");

            Console.ReadLine();
        }
    }
}
