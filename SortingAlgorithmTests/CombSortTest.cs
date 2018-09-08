using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class CombSortTest
    {
        [Fact]
        public void CombSort()
        {
            var algorithm = new CombSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
