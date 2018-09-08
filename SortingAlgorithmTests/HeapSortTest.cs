using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class HeapSortTest
    {
        [Fact]
        public void HeapSort()
        {
            var algorithm = new HeapSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
