namespace ReverseNumber
{
    public class Program
    {
        /*
          Reverse a number
         */

        static void Main(string[] args)
        {
            int result = ReverseNumber(456);
            Console.WriteLine($"Reversed number : {result}");
        }

        public static int ReverseNumber(int number)
        {
            int reverseNumber = 0;

            while (number > 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number = number / 10;
            }

            return reverseNumber;
        }


    }
}