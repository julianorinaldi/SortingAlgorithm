using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class DotNetArraySortTest
    {
        [Fact]
        public void DotNetArraySort()
        {
            var algorithm = new DotNetArraySort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
