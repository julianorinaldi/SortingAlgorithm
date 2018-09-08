namespace SortingCore
{
    public class GnomeSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            var p = 0;
            while (p < (vetor.Length - 1))
            {
                if (vetor[p] > vetor[p + 1])
                {
                    var aux = vetor[p];
                    vetor[p] = vetor[p + 1];
                    vetor[p + 1] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }

            return vetor;
        }
    }
}
