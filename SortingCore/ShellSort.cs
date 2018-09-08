namespace SortingCore
{
    public class ShellSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            var h = 1;
            var n = vetor.Length;

            while (h < n)
                h = h * 3 + 1;

            h = h / 3;

            while (h > 0)
            {
                for (var i = h; i < n; i++)
                {
                    var c = vetor[i];
                    var j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                    }

                    vetor[j] = c;
                }

                h = h / 2;
            }

            return vetor;
        }
    }
}
