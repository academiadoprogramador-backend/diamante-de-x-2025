namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Diamante de X");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine();

            Console.Write("Digite um número ímpar positivo: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
        }
    }
}
