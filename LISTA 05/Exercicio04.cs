using System;

public class Exercicio04
{
    public static void Rodar()
    {
        int[] v1 = new int[10];//declara os dois vetores
        int[] v2 = new int[10];
        PreencheVetores(v1, v2);//aciona o procedimento
        Console.WriteLine();//salta uma linha
        JuntaVetor(v1, v2);//aciona o procedimento
    }
    static void PreencheVetores(int[] a, int[] b)
    {
        Random r = new Random();
        for (int i = 0; i < 10; i++)
        {
            a[i] = r.Next(1, 101); //sorteia os valores de cada posição do vetor
            Console.WriteLine("Va= "+a[i]);//imprime cada valor 
            b[i] = r.Next(1, 101); //sorteia os valores de cada posição do vetor
            Console.WriteLine("Vb= "+b[i]); //imprime cada valor
        }
    }
    static void JuntaVetor(int[] x, int[] y)
    {
        int[] vetorao = new int[20];//cria o vetor que irá juntar os outros dois do procedimento
        for (int j = 0; j < vetorao.Length; j++)
        {
            if (j % 2 != 0)//se a posição for ímpar, então o vetor tomará como valor dessa posição o primeiro valor do vetor 1, e assim por diante
            {
                vetorao[j] = x[j/2];//posição divide por 2 pois o tamanho do vetor referido é a metade do vetorao
            }
            else //se a posição for par, então o vetor tomará como valor dessa posição o primeiro valor do vetor 2, e assim por diante
            {
                vetorao[j] = y[j/2];
            }
        }
        foreach (int item in vetorao)
        {
            Console.Write(item + " ");//imprime cada valor do vetor
        }
    }
}
