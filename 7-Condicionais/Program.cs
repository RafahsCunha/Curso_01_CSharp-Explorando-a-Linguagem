using System;

class Programa
{
    static void Main(string[] args)
    {
        int idadePessoa = 11;
        int idadeAcompanhante = 23;

        if (idadePessoa >= 18)
        {
            Console.WriteLine("Pode entrar na festa...");
        }
        else
        {
            if (idadeAcompanhante >= 21)
            {
                Console.WriteLine("Está acompanhado por um maior de " + idadeAcompanhante + " anos." +
                    " Pode entrar na festa!");
            }
            else
            {
                Console.WriteLine("O acompanhante tem " + idadeAcompanhante +
                    " anos." + " Não pode entrar na festa");
            }
        }
    }
}

