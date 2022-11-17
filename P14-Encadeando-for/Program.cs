using System;

class Programa
{
    static void Main(string[] args)
    {
     
        //*
        //**
        //***
        //****
        //*****

        // contador com break;

        for (int contatorLinha = 1; contatorLinha <=9; contatorLinha++)
        {
            for (int contadorColuna = 1; contadorColuna<=9; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contatorLinha)
                    break;
            }
            Console.WriteLine();
        }

        // contador sem break

        for (int contatorLinha = 1; contatorLinha <= 9; contatorLinha++)
        {
            for (int contadorColuna = 1; contadorColuna <= contatorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}