using System;

namespace SortingCore
{
    public class DotNetArraySort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            Array.Sort(vetor);

            return vetor;
        }
    }
}
