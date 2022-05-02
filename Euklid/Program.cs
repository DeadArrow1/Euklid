
namespace Euklid
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 61;
            int b = 97;

            Console.WriteLine("Nejvetsi spolecny delitel cisel " + a + " a " + b + " je " + EuklidAlgorithm.GCD(a, b));
          

            Console.WriteLine("Multiplikativni inverze k cislu "+ a + " modulo 97 je "+ EuklidAlgorithm.MultiplicativeInversion(a, b));





        }
    }
}

