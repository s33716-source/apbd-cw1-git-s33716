using System.Reflection.Emit;

namespace gitTest
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                string input = "end";
                uint n;
                Console.WriteLine("Gimme a long so I can turn it into a fib. Type \"end\" to quit.");
                try
                {
                    input = Console.ReadLine();
                    n = uint.Parse(input);
                }
                catch(Exception e)
                {
                    if(input == "end")
                        break;
                    Console.WriteLine("Input provided is invalid.");
                    continue;
                }
                
                Console.WriteLine($"The nth fib number is {Fib(n)}");
            }
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