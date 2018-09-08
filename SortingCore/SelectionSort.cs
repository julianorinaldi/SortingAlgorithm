namespace SortingCore
{
    public class SelectionSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                var min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    var aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }
    }
}
