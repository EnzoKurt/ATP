using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Categoria de nadadores - A até F - N é nenhuma categoria");
        for (int i = 0; i < 10; i++)
        {//verifica a categoria até 10 vezes
            Console.WriteLine("Digite a idade do nadador:");
            int a = int.Parse(Console.ReadLine());//coleta a idade
            Console.WriteLine("Categoria = " + categoria(a));//imprime a categoria baseado na verificação da função
            Console.ReadKey();//deixa que o usuário veja a categoria antes do console clear apagar o console
            Console.Clear();
        }
    }
    static char categoria(int x)
    {
        if (x > 4)
        {
            if (x >= 5 && x <= 7) return 'F';//se for maior ou igual a 5 anos e menor ou igual a 7, então retorna o caractere F
            else if (x <= 10) return 'E';//se for menor ou igual a 10 anos, então retorna o caractere E
            else if (x <= 13) return 'D';//se for menor ou igual a 13 anos, então retorna o caractere D
            else if (x <= 15) return 'C';//se for menor ou igual a 15 anos, então retorna o caractere C
            else if (x <= 17) return 'B';//se for menor ou igual a 17 anos, então retorna o caractere B
            else return 'A';//se não for nenhuma dessas condições, retorna o caractere A
        }
        else
        {
            return 'N';
        }
    }
}
