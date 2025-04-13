using System;

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("belmayer");
        
        Console.WriteLine($"Titular: {conta.Titular}\n");

        conta.Depositar(300);
        conta.MostrarInfo();

        Console.WriteLine("\nsaque: R$ 700,00");
        conta.Sacar(500);

        conta.Sacar(200);
        conta.MostrarInfo();
    }
}
