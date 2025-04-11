namespace DiamanteDeX.ConsoleApp;

public static class GeradorDeDiamante
{
    static int quantidadeDeLinhas;
    static int quantidadeDeX;
    static int quantidadeDeEspacos;

    public static void DesenharDiamante(int tamanhoDoDiamante)
    {
        quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;
        quantidadeDeX = 1;
        quantidadeDeEspacos = quantidadeDeLinhas;

        DesenharParteSuperior();

        DesenharParteDoMeio(tamanhoDoDiamante);

        DesenharParteInferior();
    }

    public static void DesenharParteSuperior()
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

    public static void DesenharParteDoMeio(int tamanhoDiamante)
    {
        for (int x = 0; x < tamanhoDiamante; x++)
            Console.Write("x");

        Console.WriteLine();
    }

    public static void DesenharParteInferior()
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
