using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000.0;
                
        // Inicializador // condição // contador   
        for (int mes = 1; mes <= 12; mes++)

        {   // investimento é igual a investimento + 5% de acréscimo
            investimento *= 1.005; 
            Console.WriteLine("No mes " + mes + " vc tem: R$" + investimento);
        }
    }
}