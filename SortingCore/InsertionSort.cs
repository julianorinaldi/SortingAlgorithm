namespace SortingCore
{
    public class InsertionSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            for (var i = 1; i < vetor.Length; i++)
            {
                var atual = vetor[i];
                var j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }
    }
}
