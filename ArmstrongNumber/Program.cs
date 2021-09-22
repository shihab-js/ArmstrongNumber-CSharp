using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 371 = (3*3*3)+(7*7*7)+(1*1*1)
            //declare the necessary variables
            int number, remainder, sum = 0, temp;
            //print message to show the user
            Console.Write("Please Enter a Number: ");
            //get input from user
            number = int.Parse(Console.ReadLine());
            //store the number in a temporary variable
            temp = number;
            //continue the program unit number greater than 0
            while (number > 0)
            {
                remainder = number % 10;
                sum = sum + (remainder * remainder * remainder);
                number = number / 10;

            }
            //compare the orginal number
            if (temp == sum)
            {
                Console.Write(temp + " Armstrong Number.");
            }else
                Console.Write(temp + " Not Armstrong Number.");
        }
    }
}
