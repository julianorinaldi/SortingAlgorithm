using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class OddEvenSortTest
    {
        [Fact]
        public void OddEvenSort()
        {
            var algorithm = new OddEvenSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
