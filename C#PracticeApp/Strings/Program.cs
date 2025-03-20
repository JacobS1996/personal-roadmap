namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRINGS

            // A string is, functionally, any data wrapped in "". 
            // A string is text, but that text can appear as letters, spaces, words, special characters, or numbers. 

            string numberText = "1234"; // these letters are text. They will not be treated as numbers for the purposes of mathematical operations unless they are parsed into a numerical data type. 



            string? myString; // Like other variables, you can initialize it as undefined

            myString = numberText; // you can assign a value to a string variable using other string variables

            myString = null; // null means that the variable lacks a value

            // You can also set the value of a string to be empty. The examples below differ from "null" in that they indicate that the string does have a value, but the value is blank. 

            // The following examples actually work slightly differently from one another. While they may function the same in most contexts, there are exceptions to this rule. 

            myString = string.Empty; // a read-only field, does not create an object

            myString = ""; // a constant, does create an actual object

            //----------------------------------------------------------------------------------------------------------------------------------------

            string blankSpace = "        "; // this string is not empty. It contains a series of spaces. 


            myString = "This " + "is called" + "string concatenation" + blankSpace; // STRING CONCATENATION is when you combine strings together using the + operator. The + sign is not a space but 
            // simply indicates that the strings are being attached to one another. 


            myString = $"String INTERPOLATION is an easier way to create longer strings {blankSpace}"; // STRING INTERPOLATION uses the $ sign before the quotation marks. In string interpolation,
            // variables can be directly inserted into the string using the {} marks. This makes it easier to create more complex strings, since you do not have to add + signs between each variable or 
            // string segment. 

            // You can also use COMPOSITE FORMATTING as an alternative to the above methods. 

            myString = string.Format("Here is another way to insert variables into your string: {0}, {1}", blankSpace, numberText);
            // COMPOSITE FORMATTING utilizises an index system (starts at 0) as placeholders for the respective variables/values to be supplied after the string ends. 
            // ex. 0 is filled in with blankSpace; 1 is filled in with numberText. 






        }
    }
}
