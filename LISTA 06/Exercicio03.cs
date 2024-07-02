using System;

public class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite uma frase
        Console.WriteLine("Digite uma frase:");

        // Lê a frase digitada pelo usuário
        string frase = Console.ReadLine();

        // Codifica a frase usando o método CodificarCesar com deslocamento de 3
        string fraseCodificada = CodificarCesar(frase, 3);

        // Exibe a frase codificada
        Console.WriteLine("Frase codificada:");
        Console.WriteLine(fraseCodificada);
    }

    static string CodificarCesar(string texto, int deslocamento)
    {
        // Inicializa uma string vazia para armazenar o resultado codificado
        string resultado = "";

        // Percorre cada caractere da string de entrada
        for (int i = 0; i < texto.Length; i++)
        {
            // Obtém o caractere atual
            char letra = texto[i];

            // Verifica se o caractere é uma letra minúscula
            if (letra >= 'a' && letra <= 'z')
            {
                // Subtrai 'a' para obter um índice base 0, aplica o deslocamento e usa aritmética modular
                // para garantir que o resultado esteja dentro do intervalo de letras minúsculas
                letra = (char)((letra - 'a' + deslocamento) % 26 + 'a');
            }
            // Verifica se o caractere é uma letra maiúscula
            else if (letra >= 'A' && letra <= 'Z')
            {
                // Subtrai 'A' para obter um índice base 0, aplica o deslocamento e usa aritmética modular
                // para garantir que o resultado esteja dentro do intervalo de letras maiúsculas
                letra = (char)((letra - 'A' + deslocamento) % 26 + 'A');
            }

            // Adiciona o caractere codificado (ou o original, se não for uma letra) ao resultado
            resultado += letra;
        }

        // Retorna a string resultante codificada
        return resultado;
    }
}
