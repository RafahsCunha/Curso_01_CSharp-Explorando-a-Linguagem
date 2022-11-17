using System;
using System.Linq.Expressions;



// Desafio


class Programa
{
    static void Main(string[] args)
    {
        double salario = 5600.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            double salarioIR = salario * 0.075;
            Console.WriteLine("Desconto de 7.5% do imposto de renda - IR: R$" + salarioIR);
            Console.WriteLine("Líquido a receber: R$" + (salario - salarioIR));
            Console.WriteLine("Dedução de R$ 142.00");

        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            double salarioIR = salario * 0.15;
            Console.WriteLine("Desconto de 15% do imposto de renda - IR: R$" + salarioIR);
            Console.WriteLine("Líquido a receber: R$" + (salario - salarioIR));
            Console.WriteLine("Dedução de R$ 350.00");
        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {
            double salarioIR = salario * 0.225;
            Console.WriteLine("Desconto de 22,5% do imposto de renda - IR: R$" + salarioIR);
            Console.WriteLine("Líquido a receber: R$" + (salario - salarioIR));
            Console.WriteLine("Dedução de R$ 636.00");
        }
        else
        {
            Console.WriteLine("Salario maior que R$ 4664.00, maior alíquata de desconto!");
        }
    }
}