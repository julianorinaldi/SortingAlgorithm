using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SortingCore;

namespace SortingAlgorithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorter[] sortingAlgorithms = new ISorter[]
            {
                new BubbleSort(),
                new OddEvenSort(),
                new CocktailSort(),
                new GnomeSort(),
                new SelectionSort(),
                new CombSort(),
                new InsertionSort(),
                new HeapSort(),
                new MergeSort(),
                new QuickSort(),
                new ShellSort()
            };

            Console.WriteLine($"Criando vetor para teste.");
            int[] unsortedVector = GenerateVector(0, 1000, 10000);

            Console.WriteLine($"Iniciando Algorítimos de Ordenação.");
            for (int i = 0; i < sortingAlgorithms.Length; i++)
            {
                Console.Write($"Algorithm: {sortingAlgorithms[i].ToString()}");
                var unsortedVectorTest = unsortedVector.Clone() as int[];
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sortingAlgorithms[i].Sort(unsortedVectorTest);
                stopwatch.Stop();
                Console.WriteLine($" => {stopwatch.ElapsedMilliseconds} milliseconds");
            }

            Console.WriteLine();
            Console.WriteLine("Terminado.");
            Console.ReadKey();
        }

        private static int[] GenerateVector(uint min, uint max, uint amount)
        {
            int[] vector = new int[amount];
            Random random = new Random();
            for (int i = 0; i < amount; i++)
                vector[i] = random.Next((int)min, (int)max);

            return vector;
        }

        private static int CheckSum(int[] vector)
        {
            return vector.Aggregate(vector.Length, (current, t) => unchecked(current * 314159 + t));
        }
    }
}
