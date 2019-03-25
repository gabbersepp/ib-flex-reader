namespace IbFlexReader.Tests.XmlFileTest
{
    using NUnit.Framework;

    public class TestFileHelperTests
    {
        private TestFileHelper tfh;

        [SetUp]
        public void InitTests()
        {
            tfh = new TestFileHelper();
        }

        [Test]
        public void GetSlnPathTest()
        {
            // Arrange
            bool check = false;
            string exp = @"ib-flex-reader\IbFlexReader";

            // Act
            var path = tfh.GetSlnPath().Replace("/", "\\");
            if (path.Contains(exp))
            {
                check = true;
            }

            // Assert
            Assert.IsTrue(check, $"exp: {exp}, current: {path}");
        }

        [Test]
        public void GetTestFilePathTest()
        {
            // Arrange
            string exp = @"\ib-flex-reader\IbFlexReader\IbFlexReader.Tests\bin\Release\XmlFileTest\TestFiles";
            bool check = false;

            // Act
            var path = tfh.GetTestFilePath().Replace("/", "\\");

            // Assert
            if (path.Contains(exp))
            {
                check = true;
            }

            Assert.True(check, $"exp: {exp}, current: {path}");
        }

        [Test]
        public void GetTestFilesTest()
        {
            // Arrange
            int xmlsInPath = 2;

            //Act
            var xfiles = tfh.GetXmlFiles().Count;

            //Assert
            Assert.AreEqual(xmlsInPath, xfiles);
        }

        [Test]
        public void ConvertXmlStringTest()
        {
            // Arrange
            var xmlStart = @"<FlexQueryResponse queryName=";
            bool cont = false;

            //Act
            var stringCol = tfh.ConvertXmlToString(tfh.GetXmlFiles());

            //Assert
            for (int i = 0; i < stringCol.Count; i++)
            {
                if (stringCol[i].Contains(xmlStart))
                {
                    cont = true;
                    Assert.IsTrue(cont);
                }
            }
        }
    }
}
