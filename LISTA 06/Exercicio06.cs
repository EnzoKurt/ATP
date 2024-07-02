using System;
using System.IO; // Importa o namespace System.IO para operações de entrada e saída de arquivos

public class Program
{
    public static void Main()
    {
        // Solicita ao usuário para digitar um número
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário e converte para inteiro

        int somaDivisores = 0; // Inicializa a variável para armazenar a soma dos divisores

        // Imprime uma mensagem indicando os divisores do número fornecido
        Console.WriteLine("Divisores de " + numero + ":");

        // Loop para encontrar todos os divisores do número
        for (int i = 1; i <= numero; i++)
        {
            // Verifica se o número atual i é um divisor do número fornecido
            if (numero % i == 0)
            {
                Console.WriteLine(i); // Imprime o divisor
                somaDivisores += i; // Adiciona o divisor à soma total dos divisores
            }
        }

        string caminhoArquivo = "soma_divisores.txt"; // Define o nome do arquivo de saída
        // Escreve a soma dos divisores no arquivo de texto
        File.WriteAllText(caminhoArquivo, "Soma dos divisores: " + somaDivisores);

        // Informa ao usuário que a soma dos divisores foi salva no arquivo
        Console.WriteLine("A soma dos divisores foi salva no arquivo " + caminhoArquivo);
    }
}