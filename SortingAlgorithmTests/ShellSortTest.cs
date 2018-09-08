using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class ShellSortTest
    {
        [Fact]
        public void ShellSort()
        {
            var algorithm = new ShellSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
