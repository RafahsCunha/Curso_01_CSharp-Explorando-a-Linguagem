using System;

class Programa
{
    static void Main(string[] args)
    {
        double fatorRendimento = 1.005;
        double valorInvestimento = 1000;
        for (int anos = 1;anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                valorInvestimento *= fatorRendimento;
            }
                fatorRendimento += 0.001;
            }
        Console.WriteLine("Depois de 5 anos vc terá: R$"+valorInvestimento);
    }
}