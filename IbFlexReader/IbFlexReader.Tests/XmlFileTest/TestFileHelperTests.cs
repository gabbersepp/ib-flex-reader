
using System;
using System.Linq;
using NUnit.Framework;

namespace IbFlexReader.Tests.TestXml
{
    public class TestFileHelperTests
    {

        private TestFileHelper _tfh;

        [SetUp]
        public void InitTests()
        {
            _tfh = new TestFileHelper();
        }


        [Test]
        public void GetSlnPathTest()
        {
            // Arrange
            bool check = false;
            string exp = @"ib-flex-reader\IbFlexReader";

            // Act
            var path = _tfh.GetSlnPath();
            if (path.Contains(exp))
            {
                check = true;}

            // Assert
            Assert.IsTrue(check);

        }


        [Test]
        public void GetTestFilePathTest()
        {
            // Arrange
            string exp = @"\ib-flex-reader\IbFlexReader\IbFlexReader.Tests\bin\Release\XmlFileTest\TestFiles";
            bool check = false;

            // Act
            var path = _tfh.GetTestFilePath();


            // Assert
            if (path.Contains(exp))
            {
                check = true;
            }
            
            
            Assert.True(check);

        }

        [Test]
        public void GetTestFilesTest()
        {
            // Arrange
            int xmlsInPath = 1;

            //Act
            var xfiles = _tfh.GetXmlFiles().Count;

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
            var stringCol = _tfh.ConvertXmlToString(_tfh.GetXmlFiles());

            //Assert
            for (int i = 0; i < stringCol.Count ;i++)
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
