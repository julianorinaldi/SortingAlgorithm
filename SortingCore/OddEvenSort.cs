namespace SortingCore
{
    public class OddEvenSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            var sorted = false;
            while (!sorted)
            {
                sorted = true;
                // odd-even
                for (var x = 1; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        var tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;
                        sorted = false;
                    }
                }

                // even-odd
                for (var x = 0; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        int tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;
                        sorted = false;
                    }
                }
            }
            return vetor;
        }
    }
}
