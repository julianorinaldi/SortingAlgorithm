using System;
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
                new ShellSort(),
                new DotNetLinqSort(),
                new DotNetArraySort(), 
            };

            Console.WriteLine($"Criando vetor para teste.");

            uint valorInicial = 0;
            uint valorValorFinal = 1000;
            uint quantidadeNumerosVetor = 100000;

            int[] unsortedVector = GenerateVector(valorInicial, valorValorFinal, quantidadeNumerosVetor);

            Console.WriteLine($"Hash do vetor para ordenação: {CheckSum(unsortedVector)}");

            Console.WriteLine($"Iniciando Algorítimos de Ordenação.");
            Console.WriteLine();
            for (int i = 0; i < sortingAlgorithms.Length; i++)
            {
                var unsortedVectorTest = unsortedVector.Clone() as int[];
                Console.Write($"Hash desordenado: {CheckSum(unsortedVectorTest)} => ");
                Console.Write($"Algorithm: {sortingAlgorithms[i].ToString()}");
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                unsortedVectorTest = sortingAlgorithms[i].Sort(unsortedVectorTest);
                stopwatch.Stop();
                Console.Write($" => {stopwatch.ElapsedMilliseconds} milliseconds");
                Console.WriteLine($" => Hash ordenado: {CheckSum(unsortedVectorTest)}.");
            }

            Console.WriteLine();
            Console.WriteLine("Finalizado.");
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
