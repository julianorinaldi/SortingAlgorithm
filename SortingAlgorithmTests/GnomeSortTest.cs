using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class GnomeSortTest
    {
        [Fact]
        public void GnomeSort()
        {
            var algorithm = new GnomeSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector());
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
