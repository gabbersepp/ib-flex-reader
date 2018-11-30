using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbFlexReader.Test
{    
	[TestClass]
    public class ReaderRealTest
	{
        private static string queryId = "";
        private static string token = "";

        [TestMethod]
        public void Test()
        {
            var result = new Reader().GetByApi(token, queryId);

        }
    }
}
