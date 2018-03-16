using Xunit;
using System;
using DEV_2;

namespace xUnitTest
{
    public class DEV_2
    {
        private SearchForEvenIndices objectBuilder = new SearchForEvenIndices();

        [Fact]
        public void SearchForEvenIndicesTest()
        {
            string inputString = "KoTiki $12 _^%# ' ";
            string result = "KTk 1 ^#'";
            SearchForEvenIndices input = new SearchForEvenIndices();
            Assert.Equal(input.FormatString(inputString), result);
        }

        [Fact]
        public void StringArgumentNullTest()
        {
            string inputString = null;
            Assert.Throws<ArgumentNullException>(() => objectBuilder.FormatString(inputString));
        }
    }
}
