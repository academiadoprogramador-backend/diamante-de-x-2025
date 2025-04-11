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

            int quantidadeLinhas = (tamanhoDiamante - 1) / 2;

            int quantidadeDeX = 1;
            int quantidadeDeEspacos = quantidadeLinhas;

            Console.WriteLine();

            // Parte superior do diamante
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                // Desenhar os espeços da linha
                for (int espaco = 0; espaco < quantidadeDeEspacos; espaco++)
                    Console.Write(" ");

                // Desenhar os x da linha
                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeX += 2;
                quantidadeDeEspacos--;

                Console.WriteLine();
            }

            // Parte do meio do diamante
            for (int x = 0; x < tamanhoDiamante; x++)
                Console.Write("x");

            Console.WriteLine();

            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;

            // Parte inferior do diamante
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                // Desenhar os espeços da linha
                for (int espaco = 0; espaco < quantidadeDeEspacos; espaco++)
                    Console.Write(" ");

                // Desenhar os x da linha
                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeX -= 2;
                quantidadeDeEspacos++;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
