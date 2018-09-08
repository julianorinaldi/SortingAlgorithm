using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class QuickSortTest
    {
        [Fact]
        public void QuickSort()
        {
            var algorithm = new QuickSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
