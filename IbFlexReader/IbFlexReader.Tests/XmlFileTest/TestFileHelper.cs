namespace IbFlexReader.Tests.TestXml
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using System.Xml;

    public class TestFileHelper
    {
        public IList<XmlDocument> XmlTestFiles { get; set; } = new List<XmlDocument>();
        public IList<string> ConvertedXml { get; set; } = new List<string>();

        public string TestFilePath { get; set; }
        public string SlnPath { get; set; }

        public string GetTestFilePath()
        {
            string  ext = @"/IbFlexReader.Tests/bin/Release/XmlFileTest/TestFiles";

            var slnpath = GetSlnPath();

            TestFilePath = Path.GetFullPath(slnpath + ext).Trim();
            
            return TestFilePath;
        }

        public string GetSlnPath()
        {
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var parrent1 = Directory.GetParent(exePath).ToString();
            var parrent2 = Directory.GetParent(parrent1).ToString();
            var slnPath = Directory.GetParent(parrent2).ToString();

            return slnPath;
        }

        public IList<string> ReadXmlFiles(string name)
        {
            var xml = GetXmlFiles(name);
            return ConvertXmlToString(xml);
        }

        public IList<XmlDocument> GetXmlFiles(string namePattern = null)
        {
            foreach (string file in Directory.GetFiles(GetTestFilePath(), "*.xml").Where(x => new Regex($".*{namePattern}.*").IsMatch(x)))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlTestFiles.Add(doc);
            }
            
            return XmlTestFiles;
        }

        public IList<string> ConvertXmlToString(IList<XmlDocument> xmlTestFiles)
        {
            foreach (XmlDocument file in xmlTestFiles)
            {
                var newfile = file.InnerXml.ToString();
                ConvertedXml.Add(newfile);
            }

            return ConvertedXml;
        }
    }
}
