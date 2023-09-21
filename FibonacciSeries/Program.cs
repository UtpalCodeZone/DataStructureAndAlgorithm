namespace FibonacciSeries
{
    public class Program
    {
        /*
          Fibonacci Series : 0 1 1 2 3 5 8 13 ........
         */
        static void Main(string[] args)
        {

            Console.WriteLine("0");
            Console.WriteLine("1");

            int f = 0;

            int a = 0;
            int b = 1;

            for (int i = 1; i <= 10; i++)
            {
                f = a + b;
                a = b;
                b = f;
                Console.WriteLine(f);
            }
        }
    }
}