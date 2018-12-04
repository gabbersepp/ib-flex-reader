using FluentAssertions;
using System;
using IbFlexReader.Utils;
using NUnit.Framework;

namespace IbFlexReader.Tests.Utils
{
	public class DumpFileWriterTest
	{
		[Test]
		public void ToDumpFilename()
		{
			string f = DumpFileWriter.ToDumpFilename(@"c:\Test\Dump.xml", "1");
			f.Should().Be(@"c:\Test\Dump.1.xml");

			f = DumpFileWriter.ToDumpFilename(@"c:\Test\a\b\c\Dump.xml", "123");
			f.Should().Be(@"c:\Test\a\b\c\Dump.123.xml");

			f = DumpFileWriter.ToDumpFilename(@"c:\Dump.xml", "a");
			f.Should().Be(@"c:\Dump.a.xml");

			f = DumpFileWriter.ToDumpFilename(@"c:\Test\Dump", "1");
			f.Should().Be(@"c:\Test\Dump.1");
		}
	}
}
