using NUnit.Framework;

namespace IbFlexReader.Tests
{
    public class ReaderRealTest
    {
        private string _queryId = string.Empty;
        private string _token = string.Empty;

        [Test]
        public void Test()
        {
            var result = new Reader().GetByApi(_token, _queryId);
            Assert.IsNotNull(result);

        }
    }
}
