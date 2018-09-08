namespace SortingCore
{
    public class CocktailSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            var tamanho = vetor.Length;
            var inicio = 0;
            var fim = tamanho - 1;
            var swap = 0;
            while (swap == 0 && inicio < fim)
            {
                swap = 1;
                int aux;
                for (var i = inicio; i < fim; i = i + 1)
                {
                    if (vetor[i] <= vetor[i + 1]) continue;
                    aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    swap = 0;
                }

                fim = fim - 1;

                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (vetor[i] >= vetor[i - 1]) continue;
                    aux = vetor[i];
                    vetor[i] = vetor[i - 1];
                    vetor[i - 1] = aux;
                    swap = 0;
                }

                inicio = inicio + 1;
            }

            return vetor;
        }
    }
}
