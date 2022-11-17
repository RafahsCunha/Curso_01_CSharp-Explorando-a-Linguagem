
using System;

class Programa
{
    static void Main(string[] args)
    {
        int idadePessoa = 11;
        int idadeAcompanhante = 20;
        bool acompanhante = idadeAcompanhante >= 21;

        if (idadePessoa >= 18 || acompanhante == true)
        {
            Console.WriteLine("Pode entrar na festa...");
        }
        else
        {
            Console.WriteLine("Não pode entrar na festa... \n");
        }
        Console.WriteLine("Press entrer to close...");
        Console.ReadLine();
    }
}

