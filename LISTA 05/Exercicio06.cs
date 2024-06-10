using System;

public class Exercicio06 {
    public void Rodar() {
         Temperaturas();//Chama o procedimento
  }
  static void Temperaturas(){
    int[] temp=new int [31];//cria o vetor de 31 posições
    int soma=0,menor=40,maior=0;//cria as variáveis necessárias
    double media=0;//variável que irá calcular a média
    Random sorteio=new Random();//criação do sorteador
    for(int i=0;i<temp.Length;i++){
      temp[i]=sorteio.Next(15,41);//cada posição do vetor será armazenado uma temperatura sorteada entre 15 e 40°C
      soma+=temp[i];//soma assume o valor de cada posição somando-as simultaneamente
      if(temp[i]>maior){//se a posição no vetor for maior que o valor de 'maior', 'maior' toma pra si esse valor da posição
        maior=temp[i];
      }
      if(menor>=temp[i]){//se o valor de menor for maior do que a temperatura da posição do vetor, então menor tomará essa posição como seu valor atual
        menor=temp[i];
      }
    }
    media=soma/31;//média calcula a soma de todas as temperaturas dividido pelo número de dias do mês
    foreach(int item in temp){
      Console.WriteLine(item);//percorre o vetor escrevendo o valor de cada posição
    }
    Console.WriteLine("A menor temperatura desse mês de outubro foi de {0}°C, a maior foi {1}°C e a média de temperatura foi de {2}°C.",menor, maior, media);//imprime os valores calculados
  }
}
