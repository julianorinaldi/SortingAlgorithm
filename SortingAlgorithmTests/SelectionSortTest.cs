using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class SelectionSortTest
    {
        [Fact]
        public void SelectionSort()
        {
            var algorithm = new SelectionSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
