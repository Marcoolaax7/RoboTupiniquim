
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

static class Robo
{
    public static int posicaoX;

    public static int posicaoY;

    public static char direcao;

    public static void Configurar(int pX, int pY, char dir)
    {
        posicaoX = pX;
        posicaoY = pY;
        direcao = dir;

    }


    public static void ExecutarComando()
    {

        Console.WriteLine("Digite a sequencia de Comandos: ");
        string? comando = Console.ReadLine();

        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            if (comandoAtual == 'E')
            {
                direcao = Robo.GirarParaEsquerda(direcao);
            }

            else if (comandoAtual == 'D')
            {
                direcao = Robo.GirarParaDireita(direcao);
            }
            else if (comandoAtual == 'M')
            {
                Robo.Avancar(direcao);
            }
        }
    }

    public static char Avancar(char direcao)
    {
        if (direcao == 'N') posicaoY++;
        else if (direcao == 'O') posicaoX--;
        else if (direcao == 'S') posicaoY--;
        else if (direcao == 'L') posicaoX++;

      return direcao;
    }

    public static char GirarParaEsquerda(char direcao)
    {
        if (direcao == 'N') direcao = 'O';
        else if (direcao == 'O') direcao = 'S';
        else if (direcao == 'S') direcao = 'L';
        else if (direcao == 'L') direcao = 'N';

        return direcao;
    }

    public static char GirarParaDireita(char direcao)
    {
        if (direcao == 'N') direcao = 'L';
        else if (direcao == 'L') direcao = 'S';
        else if (direcao == 'S') direcao = 'O';
        else if (direcao == 'O') direcao = 'N';

        return direcao;
    }
}
