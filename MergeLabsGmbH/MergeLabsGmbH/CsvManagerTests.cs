using NUnit.Framework;

namespace MergeLabsGmbH.Tests
{
    [TestFixture]
    public class CsvManagerTests
    {
        [Test]
        public void SimpleTransformCsv_NullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => CsvManager.SimpleTransformCsv(null));
        }

        [Test]
        public void SimpleTransformCsv_EmptyInput_ReturnsEmptyString()
        {
            Assert.AreEqual("\n", CsvManager.SimpleTransformCsv(""));
        }

        [Test]
        public void SimpleTransformCsv_SingleRowWithNull_ReturnsSameString()
        {
            string input = "header,NULL";
            string expectedOutput = "header,NULL\n";
            Assert.AreEqual(expectedOutput, CsvManager.SimpleTransformCsv(input));
        }

        [Test]
        public void SimpleTransformCsv_SingleRowWithoutNull_ReturnsSameString()
        {
            string input = "header,cell1,cell2";
            string expectedOutput = "header,cell1,cell2\n";
            Assert.AreEqual(expectedOutput, CsvManager.SimpleTransformCsv(input));
        }

        [Test]
        public void SimpleTransformCsv_MultipleRowsWithNull_ReturnsHeaderAndNonNullRows()
        {
            string input = "header,cell1,cell2\nrow1,NULL,cell3\nrow2,cell4,cell5";
            string expectedOutput = "header,cell1,cell2\nrow2,cell4,cell5\n";
            Assert.AreEqual(expectedOutput, CsvManager.SimpleTransformCsv(input));
        }

        [Test]
        public void SimpleTransformCsv_MultipleRowsWithoutNull_ReturnsSameString()
        {
            string input = "header,cell1,cell2\nrow1,cell3,cell4\nrow2,cell5,cell6";
            string expectedOutput = "header,cell1,cell2\nrow1,cell3,cell4\nrow2,cell5,cell6\n";
            Assert.AreEqual(expectedOutput, CsvManager.SimpleTransformCsv(input));
        }
    }
}
