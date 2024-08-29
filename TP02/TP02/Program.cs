//240209
class Exercicio_01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá! Digite um valor para que exibamos seu fator!al!");
        Console.Write("Valor: ");
        int x = int.Parse(Console.ReadLine());
        CalculaFatorial(ref x);
        Console.Write(x);
    }

    static void CalculaFatorial(ref int x)
    {
        int aux = x;
        for (int i = x - 1; i != 0; i--)
        {
            aux = aux * (x - i);
        }
        x = aux;
    }
}

//class Exercicio_02
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Olá! Vamos calcular quantos dias você está vivo!");
//        Console.Write("Digite o ano que você nasceu (2005): ");
//        int ano = int.Parse(Console.ReadLine());
//        Console.Write("Digite o mês que você nasceu (10): ");
//        int mes = int.Parse(Console.ReadLine());
//        Console.Write("Digite o dia que você nasceu (29): ");
//        int dia = int.Parse(Console.ReadLine());

//        int qtDias = CalculaDias(ano, mes, dia);
//        Console.Write($@"Meus parabéns, você já está aqui na terra há {qtDias} dias!");
//    }

//    static int CalculaDias(int ano, int mes, int dia)
//    {
//        int qtDias = 0;
//        qtDias += ano * 365;
//        qtDias += mes * 30;
//        qtDias += dia;

//        return qtDias;
//    }
//}

//class Exercicio_03
//{
//    public static void Main(string[] args)
//    {
//        bool isImpar;
//        Console.WriteLine("Olá! Digite um valor para que exibamos se ele é ímpar ou par");
//        Console.Write("Valor: ");
//        int valor = int.Parse(Console.ReadLine());
//        isImpar = VerificaValor(valor);
//        Console.WriteLine("O valor digitado {0} é um número {1}.", valor, isImpar ? "Ímpar" : "Par");
//    }

//    static bool VerificaValor(int valor)
//    {
//        return valor % 2 != 0;
//    }
//}

//class Exercicio_04
//{
//    public static void Main(string[] args)
//    {
//        bool isPrimo;
//        Console.WriteLine("Olá! Digite um valor para verificarmos se é primo ou não.");
//        Console.Write("Valor: ");
//        int valor = int.Parse(Console.ReadLine());
//        isPrimo = VerificaValor(valor);
//        Console.WriteLine("O valor digitado {0}{1} é primo.", valor, isPrimo ? "" : " não");
//    }

//    static bool VerificaValor(int valor)
//    {
//        bool isPrimo = true;
//        int aux = valor - 1;
//        while (isPrimo && aux != 1)
//        {
//            isPrimo = valor % aux != 0;
//            aux = aux - 1;
//        }

//        return isPrimo;
//    }
//}