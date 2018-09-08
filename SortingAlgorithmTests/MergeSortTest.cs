using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class MergeSortTest
    {
        [Fact]
        public void MergeSort()
        {
            var algorithm = new MergeSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
