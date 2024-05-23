using System;

class Program
{
    static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // Por padrão o jogador 1 começa
    static int choice; // A escolha do jogador para a posição a ser marcada
    static int flag = 0; // Verifica quem ganhou
    static void Main(string[] args)
    {
        do
        {
            Console.Clear(); // Sempre que o loop reiniciar, limpamos o console
            Console.WriteLine("Jogador 1: X e Jogador 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Vez do Jogador 2");
            }
            else
            {
                Console.WriteLine("Vez do Jogador 1");
            }
            Console.WriteLine("\n");
            Board();

            // Verifica se a posição já está marcada
            bool parseSuccess = Int32.TryParse(Console.ReadLine(), out choice);
            if (arr[choice] != 'X' && arr[choice] != 'O' && parseSuccess)
            {
                if (player % 2 == 0)
                {
                    arr[choice] = 'O';
                    player++;
                }
                else
                {
                    arr[choice] = 'X';
                    player++;
                }
            }
            else
            {
                Console.WriteLine("Desculpe, a linha {0} já está marcada com {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Por favor, aguarde 2 segundos. O tabuleiro está carregando novamente...");
                System.Threading.Thread.Sleep(2000);
            }
            flag = CheckWin();
        }
        while (flag != 1 && flag != -1);

        Console.Clear();
        Board();

        if (flag == 1)
        {
            Console.WriteLine("Jogador {0} ganhou", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Empate");
        }
        Console.ReadLine();
    }
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
        Console.WriteLine("     |     |      ");
    }
    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        // Winning Condition For First Row
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            return 1;
        }
        // Winning Condition For Second Row
        else if (arr[4] == arr[5] && arr[5] == arr[6])
        {
            return 1;
        }
        // Winning Condition For Third Row
        else if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        // Winning Condition For First Column
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            return 1;
        }
        // Winning Condition For Second Column
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            return 1;
        }
        // Winning Condition For Third Column
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            return 1;
        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        // If all the cells or values filled with X or O then any player has won the match
        else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }
}

