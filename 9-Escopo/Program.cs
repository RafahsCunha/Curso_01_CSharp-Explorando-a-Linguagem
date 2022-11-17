
using System;

class Programa
{
    static void Main(string[] args)
    {
        int idadePessoa = 18;
        int idadeAcompanhante = 20;
        bool acompanhante = idadeAcompanhante >= 21;

        string textoAdicional = "Está acompanhado";
        string textoAdicional_02 = "Não está acompanhado mais é maior de idade";
      
        if (idadePessoa >= 18 || acompanhante == true)
        {
            if (acompanhante == true) { Console.WriteLine(textoAdicional + "\n"); }
            if (acompanhante == false) { Console.WriteLine(textoAdicional_02 + "\n"); }
            
            Console.WriteLine("Pode entrar na festa... \n");
        }
        else
        {
            Console.WriteLine("Não pode entrar na festa... \n");
        }
        Console.WriteLine("Press entrer to close...");
        Console.ReadLine();
    }
}

