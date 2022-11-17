using System;

class Programa
{
    static void Main(string[] args)
    {

        // Programa multiplos de 3, de 1 a 100; 1º possibilidade
        int multiplo = 3;

        for (int numero = 1; numero <= 100; numero++)
        {
            int resultado = multiplo * numero;

            if (resultado > 100)
                break;
            Console.WriteLine(resultado);
        }

        // Programa multiplos de 3, de 1 a 100; 2º possibilidade

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}



