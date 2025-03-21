namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRINGS

            // BASIC INFORMATION

            System.String newString = "";
            string secondString = ""; // these two ways of using strings are functionally the same; however, it is easier to use string as it allows you 
            // to bypass typing out System.String; alternatively, you could create a using statement (using System), but it is still more common to use string rather than String in most cases. 

            
            // A string is, functionally, any data wrapped in "". 
            // A string is text, but that text can appear as letters, spaces, words, special characters, or numbers. 

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            // DECLARING STRINGS - EXAMPLES

            string numberText = "1234"; // these letters are text. They will not be treated as numbers for the purposes of mathematical operations unless they are parsed into a numerical data type. 



            string? myString; // Like other variables, you can initialize it as undefined

            myString = numberText; // you can assign a value to a string variable using other string variables

            myString = null; // null means that the variable lacks a value

            // You can also set the value of a string to be empty. The examples below differ from "null" in that they indicate that the string does have a value, but the value is blank. 

            // The following two examples actually work slightly differently from one another. While they may function the same in most contexts, there are exceptions to this rule. 

            myString = string.Empty; // a read-only field, does not create an object

            myString = ""; // a constant, does create an actual object


            string blankSpace = "        "; // this string is not empty. It contains a series of spaces. 


            //----------------------------------------------------------------------------------------------------------------------------------------

            // FORMATTING STRINGS

            myString = "This " + "is called" + "string concatenation" + blankSpace; // STRING CONCATENATION is when you combine strings together using the + operator. The + sign is not a space but 
            // simply indicates that the strings are being attached to one another. 


            myString = $"String INTERPOLATION is an easier way to create longer strings {blankSpace}"; // STRING INTERPOLATION uses the $ sign before the quotation marks. In string interpolation,
            // variables can be directly inserted into the string using the {} marks. This makes it easier to create more complex strings, since you do not have to add + signs between each variable or 
            // string segment. 

            // You can also use COMPOSITE FORMATTING as an alternative to the above methods. 

            myString = string.Format("Here is another way to insert variables into your string: {0}, {1}", blankSpace, numberText);
            // COMPOSITE FORMATTING utilizises an index system (starts at 0) as placeholders for the respective variables/values to be supplied after the string ends. 
            // ex. 0 is filled in with blankSpace; 1 is filled in with numberText. 

            myString = $"You can also use special characters to format strings. \n This special character creates a line break. \"These special characters allow you to use " +
                $"quotation marks within your string.\" There are many other special characters with unique functionality."; // Special characters

            

            myString = @"www.fakewebsite.com\notarealwebsite"; // the @ symbol before the quotation marks allows you to create VERBATIM STRINGS
            // VERBATIM STRINGS treat the string exactly as it is written, ignoring any special characters that would otherwise have separate functionality.
            // this is especially useful when the string is a url or file path

            //---------------------------------------------------------------------------------------------------------------------------------------------------

            // PRINTING STRINGS TO CONSOLE

            Console.WriteLine("The Console.WriteLine method prints strings to console");

            Console.WriteLine("\nYou can format these messages in all the ways mentioned above.");

            Console.WriteLine($"\nConsole.WriteLine will also automatically parse numbers, like {1}, into strings.");

            Console.Write("Please enter some text: "); // Console.Write is similar to Console.WriteLine, but it does not include a line break after the printed string, whereas Console.WriteLine
            // automatically creates a line break at the end of the string. 

            string userInput = Console.ReadLine(); // you can capture user input as a string using the Console.ReadLine method. 

            Console.WriteLine(userInput);

            Console.ReadLine(); // this allows the program to stay open until a key is pressed; it prevents it from closing too quickly when the application has been run. 

            








        }
    }
}
