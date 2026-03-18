using System.Reflection.Emit;

namespace gitTest
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Fib(10));
        }

        public static ulong Fib(uint n)
        {
            if(n == 0)
                return 0;
            if(n == 1)
                return 1;

            ulong i1 = 0;
            ulong i2 = 1;
            for(int i = 2; i <= n; i++)
            {
                ulong tmp = i1 + i2;
                i1 = i2;
                i2 = tmp;
            }
            return i2;
        }
    }
}