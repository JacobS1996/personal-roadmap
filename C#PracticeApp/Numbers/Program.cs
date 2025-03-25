namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INT

            Int32 int32Example = Int32.MaxValue;

            // Int32 is an integer with 32 bits. 

            Console.WriteLine("Int32's maximum value within it's range is " + int32Example + "\n");
            Console.WriteLine("Int32's minimum value within it's range is " + Int32.MinValue + "\n");

            int intExample = int.MaxValue;

            // an int is similar to an Int32, but it is most common to use int rather than Int32. 

            Console.WriteLine("int's maximum value within it's range is " + intExample + "\n");
            Console.WriteLine("int's minimum value within it's range is " + int.MinValue + "\n");

            Int64 int64Example = Int64.MaxValue;

            Console.WriteLine("int's maximum value within it's range is " + int64Example + "\n");
            Console.WriteLine("int's minimum value within it's range is " + Int64.MinValue + "\n");

            // Int64 has an exponentially greater range than an Int32 or int. However, there are not many cases where it would be necessary to use an Int64, and doing 
            // so will use more memory unnecessarily. 


            // Working with integers

            // Integers are whole numbers. They do not contain decimals. 

            // Adding, subtracting, and multiplication with integers is fine as long as you are only working with whole numbers

            int sum = 1 + 23;
            int difference = 1 - 23;
            int product = 1 * 23;

            // There are issues, however, with trying to divide integers

            int quotient = 10 / 4;

            Console.WriteLine($"The answer to 10 / 4 should be 2.5, but the integer value returned is {quotient}. In C#, integers cannot contain decimal places. Rather than " +
                "rounding to the nearest whole number, however, the system cuts off any decimal places following the whole number. So, instead of 2.5 being rounded to 3, the system simply " +
                "takes the whole number 2 and ignores everything after it. For this reason, it is not generally recommended to perform complex mathematical operations, especially division, with " +
                "integers.\n");

            int remainder = 10 % 4;

            Console.WriteLine($"The % operator will give the remainder of dividing two numbers. For the example of 10 / 4, the remainder is {remainder}." +
                $" There are a number of uses for this operator, including determining if an integer is even or odd.");


            // DOUBLES

            // DECIMALS
            Console.ReadLine();


        }
    }
}
