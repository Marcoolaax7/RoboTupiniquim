using System;

/*

● Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma
letra que representa a direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
● Comandos: A AEB envia strings de comando simples (E, D, M):
1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
2. M (Mover) move o robô uma posição no grid para frente, mantendo a direção.
-----------------------------------------------------------------------------------------
3. A posição inicial (1 2 N), dada por 2 inteiros (X e Y) e uma letra (Orientação), separados
por espaços.
4. Uma série de instruções (E, D, M) que o robô deve seguir.

Passo 1: ler a posicao inicial(1 2 N)

Passo 2: Receber comandos(EMEMEMEMM)

Passo 3: Executar cada comando(if, else)

Passo 4: Exibir resultado(1 3 N)

1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
*/

class Program
{
    static void Main(string[] args)
    {
        Robo.Configurar(1, 2, 'N');


        //Console.Clear();
        Console.WriteLine("---------------------");
        Console.WriteLine("Robo Tupiniquim");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Posicao inicial: {Robo.posicaoX} {Robo.posicaoY} {Robo.direcao}");

        Robo.ExecutarComando();

        Console.WriteLine($"Sua posicao final é {Robo.posicaoX} {Robo.posicaoY} {Robo.direcao}.");
        Console.ReadLine();


    }

}
