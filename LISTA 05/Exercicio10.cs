using System;

public class Exercicio10 {
    public void Rodar() {
        // Declara uma matriz 10x10 de inteiros.
        int[,] matriz = new int[10, 10];

        // Chama o método Preenche para preencher a matriz com valores aleatórios.
        Preenche(matriz);

        // Imprime uma mensagem indicando que a matriz com as linhas 2 e 8 trocadas será exibida.
        Console.WriteLine("Matriz com Linhas 2 e 8 trocadas:");

        // Chama o método TrocaLinhaDoisLinhaOito para trocar as linhas 2 e 8.
        TrocaLinhaDoisLinhaOito(matriz);

        // Imprime uma mensagem indicando que a matriz com as colunas 4 e 10 trocadas será exibida.
        Console.WriteLine("Matriz com Colunas 4 e 10 trocadas:");

        // Chama o método TrocaColunaQuatroColunaDez para trocar as colunas 4 e 10.
        TrocaColunaQuatroColunaDez(matriz);

        // Imprime uma mensagem indicando que a matriz com as diagonais principal e secundária trocadas será exibida.
        Console.WriteLine("Matriz com Diagonal principal e secundária trocadas:");

        // Chama o método TrocaDiagonais para trocar as diagonais principal e secundária.
        TrocaDiagonais(matriz);

        // Imprime uma mensagem indicando que a matriz com a linha 5 e a coluna 10 trocadas será exibida.
        Console.WriteLine("Matriz com Linha 5 e coluna 10 trocadas:");

        // Chama o método TrocaLinhaCincoColunaDez para trocar a linha 5 e a coluna 10.
        TrocaLinhaCincoColunaDez(matriz);
    }

    // Método para preencher a matriz com valores aleatórios.
    static void Preenche(int[,] x)
    {
        // Cria um objeto Random para gerar números aleatórios.
        Random sorte = new Random();

        // Loop para preencher cada célula da matriz com um valor aleatório entre 1 e 9.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                // Atribui um valor aleatório à célula atual.
                x[i, j] = sorte.Next(1, 10);

                // Imprime o valor atribuído seguido de uma tabulação.
                Console.Write(x[i, j] + "\t");
            }

            // Pula para a próxima linha da matriz na impressão.
            Console.WriteLine();
        }
    }

    // Método para trocar a linha 2 (índice 1) com a linha 8 (índice 7) da matriz.
    static void TrocaLinhaDoisLinhaOito(int[,] x)
    {
        // Declara arrays temporários para armazenar as linhas 2 e 8.
        int[] Ldois = new int[10];
        int[] Loito = new int[10];

        // Copia a linha 2 da matriz para o array Ldois.
        for (int i = 1, j = 0; j < 10; j++)
        {
            Ldois[j] = x[i, j];
        }

        // Copia a linha 8 da matriz para o array Loito.
        for (int i = 7, j = 0; j < 10; j++)
        {
            Loito[j] = x[i, j];
        }

        // Substitui a linha 2 pela linha 8.
        for (int i = 1, j = 0; j < 10; j++)
        {
            x[i, j] = Loito[j];
        }

        // Substitui a linha 8 pela linha 2.
        for (int i = 7, j = 0; j < 10; j++)
        {
            x[i, j] = Ldois[j];
        }

        // Imprime a matriz modificada.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método para trocar a coluna 4 (índice 3) com a coluna 10 (índice 9) da matriz.
    static void TrocaColunaQuatroColunaDez(int[,] x)
    {
        // Declara arrays temporários para armazenar as colunas 4 e 10.
        int[] Cquatro = new int[10];
        int[] Cdez = new int[10];

        // Copia a coluna 4 da matriz para o array Cquatro.
        for (int i = 0, j = 3; i < 10; i++)
        {
            Cquatro[i] = x[i, j];
        }

        // Copia a coluna 10 da matriz para o array Cdez.
        for (int i = 0, j = 9; i < 10; i++)
        {
            Cdez[i] = x[i, j];
        }

        // Substitui a coluna 4 pela coluna 10.
        for (int i = 0, j = 3; i < 10; i++)
        {
            x[i, j] = Cdez[i];
        }

        // Substitui a coluna 10 pela coluna 4.
        for(int i = 0, j = 9; i < 10; i++)
        {
            x[i, j] = Cquatro[i];
        }

        // Imprime a matriz modificada.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método para trocar as diagonais principal e secundária da matriz.
    static void TrocaDiagonais(int[,] x)
    {
        // Declara arrays temporários para armazenar as diagonais principal e secundária.
        int[] Dprinc = new int[10];
        int[] Dsec = new int[10];

        // Copia a diagonal principal da matriz para o array Dprinc.
        for (int i = 0, j = 0; i < 10 && j < 10; j++, i++)
        {
            Dprinc[i] = x[i, j];
        }

        // Copia a diagonal secundária da matriz para o array Dsec e substitui a diagonal secundária pela principal.
        for (int i = 0, j = 9; i < 10 && j >= 0; i++, j--)
        {
            Dsec[i] = x[i, j];
            x[i, j] = Dprinc[i];
        }

        // Substitui a diagonal principal pela diagonal secundária.
        for (int i = 0, j = 0; i < 10 && j < 10; j++, i++)
        {
            x[i, j] = Dsec[j];
        }

        // Imprime a matriz modificada.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método para trocar a linha 5 (índice 4) com a coluna 10 (índice 9) da matriz.
    static void TrocaLinhaCincoColunaDez(int[,] x)
    {
        // Declara arrays temporários para armazenar a linha 5 e a coluna 10.
        int[] Lcinco = new int[10];
        int[] Cdez = new int[10];

        // Copia a linha 5 da matriz para o array Lcinco.
        for (int i = 4, j = 0; j < 10; j++)
        {
            Lcinco[j] = x[i, j];
        }

        // Copia a coluna 10 da matriz para o array Cdez e substitui a coluna 10 pela linha 5.
        for (int i = 0, j = 9; i < 10; i++)
        {
            Cdez[i] = x[i, j];
            x[i, j] = Lcinco[i];
        }

        // Substitui a linha 5 pela coluna 10.
        for (int i = 4, j = 0; j < 10; j++)
        {
            x[i, j] = Cdez[j];
        }

        // Imprime a matriz modificada.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

}
