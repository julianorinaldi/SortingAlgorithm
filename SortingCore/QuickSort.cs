namespace SortingCore
{
    public class QuickSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            Sort(vetor, 0, vetor.Length - 1);

            return vetor;
        }

        private void Sort(int[] vetor, int inicio, int fim)
        {
            if (inicio >= fim) return;

            int p = vetor[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor[i] <= p)
                    i++;
                else if (p < vetor[f])
                    f--;
                else
                {
                    var troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor[inicio] = vetor[f];
            vetor[f] = p;

            Sort(vetor, inicio, f - 1);
            Sort(vetor, f + 1, fim);
        }
    }
}
