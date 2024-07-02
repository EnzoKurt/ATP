using System;

public class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite uma frase");//imprime mensagem ao usuário
    string frase = Console.ReadLine();//recebe a frase do usuário
    string vogais="aeiouAEIOU";//criação do vetor com os caracteres referentes a vogais
    string semVogais="";//variável inicia sem nenhum caractere
    foreach(char v in frase){//percorre uma variável por todas as letras da frase do usuário
      if(!vogais.Contains(v)){//se não contem vogal na posição, então escreve essa letra na variável semVogais
        semVogais+=v;
      }
    }
    Console.WriteLine(semVogais);//imprime a frase sem vogais
  }
}