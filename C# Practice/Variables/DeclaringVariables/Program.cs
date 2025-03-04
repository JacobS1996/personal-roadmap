namespace DeclaringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEXT

            // declare the variable by specifying the data type
            // in this case, the data type is char, which means a single character

            char thisCharacter = 'a'; // use single quotes for characters

            // after specifying the data type, specify the variable name
            // it is a standard convention to have the first word be lower-cased and subsequent words capitalized. This is referred to as Camel case

            string thisString = "this is a string";


            // a string refers to text. A string can be a single character or a sequence of characters, including words, spaces, numbers, etc.
            // while a string can have a single character, it is still a different data type and is treated differently in some contexts from a char. 


            thisString = "this is a new value"; // you can change the values of string variables after having declared them

            // the question mark after the data type specifies that the variable is nullable

            string? secondString; // you can initialize strings as undefined
            secondString = string.Empty; // you can make them empty
            secondString = null; // you can set their value to null
            secondString = "";

            string? userInput = Console.ReadLine(); // this asks the user for input

            Console.WriteLine(thisString);
            Console.WriteLine(thisCharacter);
            Console.WriteLine(secondString);
            Console.WriteLine(userInput);

            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // BOOLS

            // can have a value of either true or false

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
