using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Por favor, preencha a matriz 3x3 com valores numéricos: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma da Linha {i + 1}: {somaLinha}");
        }

        for (int j = 0; j < 3; j++)
        {
            int somaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                somaColuna += matriz[i, j];
            }
            Console.WriteLine($"Soma da Coluna {j + 1}: {somaColuna}");
        }
    }
}
