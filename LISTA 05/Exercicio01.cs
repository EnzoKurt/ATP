using System;

public class Exercicio01 {
    public void Rodar() {
        int[] n=new int[20];//declara o vetor de tamanho 20
    Random r=new Random();//sorteador
    for(int i=0;i<20;i++){  
      n[i]=r.Next(1,20);//cada posição do vetor, é sorteado um número de 1 a 20
      Console.WriteLine(n[i]);//imprime cada valor sorteado
    }
    int m=n[0],p=0;//m inicia sendo a primeira posição do vetor n
    for(int i=0;i<n.Length;i++){  //percorre o vetor n
      if(n[i] < m) {//verifica se o valor atual do percurso é menor que o inicial. Se sim, então m tomará seu valor até encontrar outro que seja menor
        m=n[i];
        p=i+1;//posição +1 é porque é usual para nós humanos começarmos a contar pelo 1 e não pelo 0, como é no computador
        }
    }
    Console.WriteLine("Menor => {0}\nPosição => {1}", m,p);//imprime a mensagem com o menor valor do vetor e a posição do mesmo
  }
}