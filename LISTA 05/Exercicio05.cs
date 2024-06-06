using System;

public class Exercicio05 {
    public void Rodar() {
       int[]vetor=Sorteio();//vetor criado pega pra si o vetor sorteado na função
    Tentativas(vetor);//aciona o procedimento
    Console.Write("Números Sorteados: ");//após o procedimento, o sistema mostra os números sorteados
    foreach(int item in vetor){
      Console.Write(item+"\t");
    }
  }
  static int[] Sorteio(){
    int[] x= new int[3];//vetor de 3 posições
    Random r=new Random();//criação do sorteador
    for(int i=0;i<x.Length;i++){
      x[i]=r.Next(10,51);//cada posição do vetor recebe um número sorteado
    }
    return x;//retorna o vetor
  }
  static void Tentativas(int[] x){
    for(int i=0;i<40;i++){//40 repetições pois de 10 a 50 tem 40 possibilidades inteiras
      Console.WriteLine("Digite um número de 10 a 50 e cruze os dedos!");
      int num=int.Parse(Console.ReadLine());//coleta do número do usuário
      if(num==x[0]||num==x[1]||num==x[2]){//se o número for igual a algum dos números sorteados, então imprime a mensagem abaixo e para o procedimento
        Console.WriteLine("Parabéns! Você acertou um dos números premiados");
        break;
        }
      else{//se não, usuário digita outro número
        Console.WriteLine("Tente novamente");
        Console.Clear();
      }
    }
    }
}
