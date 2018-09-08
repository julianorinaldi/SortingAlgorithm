namespace SortingCore
{
    public class HeapSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            BuildMaxHeap(vetor);
            var n = vetor.Length;

            for (var i = vetor.Length - 1; i > 0; i--)
            {
                Swap(vetor, i, 0);
                MaxHeapify(vetor, 0, --n);
            }

            return vetor;
        }

        private void BuildMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(v, i, v.Length);
            }
        }

        private void MaxHeapify(int[] v, int pos, int n)
        {
            int max = 2 * pos + 1, right = max + 1;
            if (max < n)
            {
                if (right < n && v[max] < v[right])
                {
                    max = right;
                }
                if (v[max] > v[pos])
                {
                    Swap(v, max, pos);
                    MaxHeapify(v, max, n);
                }
            }
        }

        private void Swap(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
        }
    }
}
