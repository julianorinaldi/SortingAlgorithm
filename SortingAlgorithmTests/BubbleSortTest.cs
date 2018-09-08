using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class BubbleSortTest
    {
        [Fact]
        public void BubbleSort()
        {
            var algorithm = new BubbleSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
