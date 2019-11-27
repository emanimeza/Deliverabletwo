using System;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int checksum = 0;

            Console.Write(" What is your message? ");
            input = Console.ReadLine();

            input = input.ToUpper();

            foreach (char c in input)
            {

                int code = (int)c;
                checksum += code; //point 9 from rubric 
                code = code - 64; //shifts the unicode value to code correctly
                message += code.ToString() + "-"; //point 8 from rubric 

            }
            message = message.TrimEnd('-');

            Console.WriteLine("Your encoded message is " + message); //point 10 from rubric 
            Console.WriteLine("Message checksum is " + checksum);


        }
    }
}