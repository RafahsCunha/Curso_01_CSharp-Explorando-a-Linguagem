using System;

class Programa
{
    static void Main(string[] args)
    {

        double salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario; // Convertendo a variável salário para int
        Console.WriteLine(salarioInteiro);
        // int => suporta até 32 bits de dígitos, não suporta números muito grandes


        // Para armazenar grandes valores do tipo int, usa-se a variável long, ele suporta 64 bits

        long x = 20000000000000000;
        Console.WriteLine(x);

        // A variável do tipo short armazena pequenas qtds de bit, suporta até 16 bits.
        short y = 15000;
        Console.WriteLine(y);

        // Variável float, o f no final do número indica que realmente queremos trabalhar com float
        float altura = 1.62f; // f indica que é um valor float
        Console.WriteLine(altura);
        

        Console.WriteLine("Pressione enter para fechar...");
        Console.ReadLine();
    }
}