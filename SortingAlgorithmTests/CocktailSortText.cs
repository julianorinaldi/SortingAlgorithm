using SortingCore;
using Xunit;

namespace SortingAlgorithmTests
{
    public class CocktailSortText
    {
        [Fact]
        public void CocktailSort()
        {
            var algorithm = new CocktailSort();
            var sortedVector = algorithm.Sort(DataDefinition.UnsortedVector);
            Assert.Equal(DataDefinition.SortedVector, sortedVector);
        }
    }
}
