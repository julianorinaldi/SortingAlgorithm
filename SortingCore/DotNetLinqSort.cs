using System.Linq;

namespace SortingCore
{
    public class DotNetLinqSort : ISorter
    {
        public int[] Sort(int[] vetor)
        {
            var vectorResult = vetor.OrderBy(x => x);
            return vectorResult.ToArray();
        }
    }
}
