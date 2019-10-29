using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de M & N: ");
            string[] tam = Console.ReadLine().Split(' ');
            int m = int.Parse(tam[0]);
            int n = int.Parse(tam[1]);

            int[,] matriz = new int[m, n];

            for(int i=0; i<m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Entre com o valor a ser procurado");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
