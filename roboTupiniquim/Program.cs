namespace roboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tamanho do grid X: ");
            int gridX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do grid y: ");
            int gridY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a posição inicial de x: ");
            int posicaoInicialx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição inicial de Y: ");
            int posicaoInicialy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a direção do robô em (N) (S) (L) (O): ");
            char direcao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira as intruções: ");

            string comando = Console.ReadLine();

            char[] comandoChar = comando.ToCharArray();

            for (int i = 0; i < comando.Length; i++)
            {
                if (comandoChar[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posicaoInicialy++;
                    }
                    else if (direcao == 'S')
                    {
                        posicaoInicialy--;
                    }
                    else if (direcao == 'L')
                    {
                        posicaoInicialx++;
                    }
                    else if (direcao == 'O')
                    {
                        posicaoInicialx--;
                    }
                }
                else if (comandoChar[i] == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }
                else if (comandoChar[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                }
            }

            Console.WriteLine(" Posição inicial x: " + posicaoInicialx + (" posição inicial y: " + posicaoInicialy + " direção: " + direcao));
            Console.WriteLine();

            // ROBO 2 

            Console.WriteLine("Digite a posição inicial de x: ");
            int posicaoInicialx2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição inicial de Y: ");
            int posicaoInicialy2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a direção do robô em (N) (S) (L) (O): ");
            char direcao2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira as intruções: ");

            string comando2 = Console.ReadLine();

            char[] comandoChar2 = comando2.ToCharArray();

            for (int i = 0; i < comando2.Length; i++)
            {
                if (comandoChar2[i] == 'M')
                {
                    if (direcao2 == 'N')
                    {
                        posicaoInicialy2++;
                    }
                    else if (direcao2 == 'S')
                    {
                        posicaoInicialy2--;
                    }
                    else if (direcao2 == 'L')
                    {
                        posicaoInicialx2++;
                    }
                    else if (direcao2 == 'O')
                    {
                        posicaoInicialx2--;
                    }
                }
                else if (comandoChar2[i] == 'D')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }
                }
                else if (comandoChar2[i] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }
                }
            }

            Console.WriteLine(" Posição inicial robô 2 x: " + posicaoInicialx2 + (" posição inicial  robô 2 y: " + posicaoInicialy2 + " direção robô 2: " + direcao2));

            Console.ReadLine();
        }
    }
}