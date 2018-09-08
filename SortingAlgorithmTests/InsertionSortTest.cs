using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class InsertionSortTest
    {
        [Fact]
        public void InsertionSort()
        {
            var algorithm = new InsertionSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
