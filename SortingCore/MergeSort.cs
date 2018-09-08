namespace SortingCore
{
    public class MergeSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            vetor = Sort(vetor, 0, vetor.Length - 1);

            return vetor;
        }

        public int[] Sort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                input = Sort(input, low, middle);
                input = Sort(input, middle + 1, high);
                input = Sort(input, low, middle, high);
            }

            return input;
        }

        private int[] Sort(int[] vetor, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (vetor[left] < vetor[right])
                {
                    tmp[tmpIndex] = vetor[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = vetor[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = vetor[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = vetor[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                vetor[low + i] = tmp[i];
            }

            return vetor;
        }
    }
}
