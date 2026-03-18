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
                Console.WriteLine("Gimme a long so I can turn it into a fib. Type \"end\" to quit. Type \"bee\" instead for bee movie.");
                try
                {
                    input = Console.ReadLine();
                    n = uint.Parse(input);
                }
                catch(Exception e)
                {
                    if(input == "end")
                        break;
                    if(input == "bee")
                    {
                        BeeMovieReader();
                        break;
                    }
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

        public static void BeeMovieReader()
        {
            StreamReader sr = new("../../../beemovie.txt");
            Console.WriteLine(sr.ReadToEnd());
        }

        public static double CalculateAverage(int[] values)
        {
            return (double)values.Sum() / values.Length;
        }

        public static int CalculateMax(int[] values)
        {
            return values.Max();
        }
        
        public static int CalculateMin(int[] values)
        {
            Console.WriteLine("lol you cant use the Min() function stupid");
            return values.Min();
        }
        
        public static void DoNothingAtAll()
        {
            
        }
    }
}