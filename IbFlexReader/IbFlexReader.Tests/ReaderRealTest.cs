using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbFlexReader.Test
{    
    public class ReaderRealTest
    {
        private static string queryId = "";
        private static string token = "";

        [Test]
        public void Test()
        {
            var result = new Reader().GetByApi(token, queryId);

        }
    }
}
