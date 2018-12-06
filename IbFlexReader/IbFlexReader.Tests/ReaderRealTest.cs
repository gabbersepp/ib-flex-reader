using NUnit.Framework;

namespace IbFlexReader.Tests
{
    public class ReaderRealTest
    {
        // fill with proper values to run the tests
        private string _queryId = string.Empty;
        private string _token = string.Empty;

        [Test]
        public void GetByApi()
        {
            Assert.Inconclusive("add valid queryID and token to run this test");
            var result = new Reader().GetByApi(_token, _queryId, @"c:\Tests\Dump.xml");
            result.Wait();
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetByString()
        {
            Assert.Inconclusive("add valid queryID and token to run this test");
            string xml = System.IO.File.ReadAllText(@"c:\Tests\Dump.2.xml");
            var result = new Reader().GetByString(xml);
            Assert.IsNotNull(result);
        }
    }
}
