using CleanCodeExamples;

namespace FunctionsTests
{
    [TestClass]
    public class LinkedListDemoTests
    {
        [TestMethod]
        public void Add_AddsElementToList()
        {
            // Arrange
            LinkedListDemo list = new LinkedListDemo();

            // Act
            list.Add(42);

            // Assert
            Assert.AreEqual(1, list.GetSize());
        }

        [TestMethod]
        public void Add_GrowsListWhenAtCapacity()
        {
            // Arrange
            LinkedListDemo list = new LinkedListDemo();
            list.totalCapacity = 1;

            // Act
            list.Add(42);
            list.Add(24);

            // Assert
            Assert.AreEqual(2, list.GetSize());
        }

        [TestMethod]
        public void Print_PrintsCorrectly()
        {
            // Arrange
            LinkedListDemo list = new LinkedListDemo();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                list.Print();
                string expectedOutput = "1 -> 2 -> 3 -> null" + Environment.NewLine;

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}