using System;
using System.Security.Cryptography.X509Certificates;

class Programa
{
    static void Main(String[] args)
    {
        // Tipo de variável utilizada no csharp para armazenar apenas 1 caracter dentro da variável
        // Ex: chat letra = 'a'; O char armazena até 16 bits
        
        char letra = 'a';

        // 65 é referente a letra A maiúscula na tabela ASCII, o char ler valores dessa tabela
        letra = (char)65;
        Console.WriteLine("Letra A representada em numero da tabela ASCII: " + letra);

        // Letra B da tabela ASCII
        letra = (char)(65 + 1);
        Console.WriteLine("Letra B da tabela: " + letra);
        
        
        // string Armazena textos longos
        string nome = "Rafael Henrique";

        Console.WriteLine("Nome da pessoa: " + nome + " Da Silva Cunha");
        Console.WriteLine("Press any key to close...");

        // O @ serve para montar uma lista simples e pular linha de cada palavra de acordo como eu identar. Ex: 

        string cursos = @"Cursos alura:  - Python
         - C# 
         - Java 
         - C++";

        Console.WriteLine("Cursos Alura: " + cursos);
        Console.ReadLine();

    }
}


















