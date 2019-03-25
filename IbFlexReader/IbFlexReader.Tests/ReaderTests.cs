namespace IbFlexReader.Tests
{
    using System.IO;
    using System.Linq;
    using IbFlexReader.Tests.XmlFileTest;
    using NUnit.Framework;

    public class ReaderTests
    {
        // fill with proper values to run the tests
        private readonly string queryId = string.Empty;
        private readonly string token = string.Empty;

        [Test]
        public void GetByApi()
        {
            Assert.Inconclusive("add valid queryID and token to run this test");
            var result = new Reader().GetByApi(token, queryId, @"c:\Tests\Dump.xml");
            result.Wait();
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetByString()
        {
            //Arrange
            var tfh = new TestFileHelper();
            var stringCol = tfh.ConvertXmlToString(tfh.GetXmlFiles());
            var result = new Reader();
            var fQR = new Contracts.FlexQueryResponse();

            //Act

            foreach (var file in stringCol)
            {
                 fQR = result.GetByString(file);
            }

            //Assert
            Assert.NotNull(fQR);
        }
    }
}
