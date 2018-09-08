using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class DotNetLinqSortTest
    {
        [Fact]
        public void DotNetLinqSort()
        {
            var algorithm = new DotNetLinqSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
