namespace DiamanteDeX.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();

        int tamanhoDoDiamante = ObterTamanhoDoDiamante();

        GeradorDeDiamante.DesenharDiamante(tamanhoDoDiamante);

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
}
