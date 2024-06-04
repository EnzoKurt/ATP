using System;

public class Exercicio02 {
    public void Rodar() {
        Console.WriteLine ("Notas alunos 2024");
    int a=10;//tamanho do vetor
    vetor(a);//aciona o procedimento
  }
  static void vetor(int x){
    int[] v= new int[x];//criação do vetor
    for(int i=0;i<v.Length;i++){
      Console.WriteLine("Digite a nota do aluno:");//coleta a nota do aluno
      v[i]=int.Parse(Console.ReadLine());//cada posição do vetor toma a nota digitada pelo usuário
    }
    media(v);//aciona o outro procedimento
  }
  static void media(int[] y){
    double m=0;
    int soma=0,am=0;//m=media,am=acima da média
    for(int i=0;i<y.Length;i++){
      soma+=y[i];//percorre o vetor e soma cada valor da posição percorrida
    }
    m=(double)soma/10;//calcula a média dividindo a soma de todas as notas pelo tamanho do vetor que possui as notas
    for(int x=0;x<y.Length;x++){
      if(y[x]>m) am++;//se a posição percorrida for maior que a média, então encrementa-se 1 no valor de am
    }
    Console.WriteLine("Média das notas dos alunos foi:{0} e a quantidade de alunos que ficaram acima da média foi:{1}", m,am);//imprime o resultado
  }
}