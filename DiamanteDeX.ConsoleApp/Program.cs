namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static int quantidadeDeLinhas;
        static int quantidadeDeX;
        static int quantidadeDeEspacos;

        static void Main(string[] args)
        {
            ExibirCabecalho();

            int tamanhoDiamante = ObterTamanhoDoDiamante();

            quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;
            quantidadeDeX = 1;
            quantidadeDeEspacos = quantidadeDeLinhas;

            DesenharParteSuperior();

            DesenharParteDoMeio(tamanhoDiamante);

            DesenharParteInferior();

            Console.ReadLine();
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Diamante de X");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine();
        }

        static int ObterTamanhoDoDiamante()
        {
            Console.Write("Digite um número ímpar positivo: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            return tamanhoDiamante;
        }

        static void DesenharParteSuperior()
        {
            Console.WriteLine();

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
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
        }

        static void DesenharParteDoMeio(int tamanhoDiamante)
        {
            for (int x = 0; x < tamanhoDiamante; x++)
                Console.Write("x");

            Console.WriteLine();
        }

        static void DesenharParteInferior()
        {
            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
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
        }
    }
}
