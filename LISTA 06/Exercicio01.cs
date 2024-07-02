using System;

public class Program {
  public static void Main (string[] args) {
    int espacos=0;//cria uma variável para os espaçoes em branco
    Console.WriteLine ("Digite uma frase:");//imprime a mensagem para o usuário
    string frase=Console.ReadLine();//recebe a frase que o usuário digitou no console
    for(int i=0;i<frase.Length;i++){//percorrerá todas as posições do vetor (ou todos os caracteres que você digitou)
      if(frase[i]==' '){//verifica se o caractere é igual a um espaço em branco
        espacos ++;//se sim, incrementa 'espaços'
      }
    }
    Console.WriteLine($"A quantidade de espaços em branco nessa frase é: {espacos}");//imprime o resultado ao usuário
  }
}