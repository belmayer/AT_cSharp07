using System;

public class ContaBancaria
{
    public string Titular { get; set; }
    private decimal saldo;

    public ContaBancaria(string titular)
    {
        Titular = titular;
        saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else if (valor > 0)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("O valor do saque tem qu ser  positivo!");
        }
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Saldo atual: R$ " + saldo.ToString("F2"));
    }
}
