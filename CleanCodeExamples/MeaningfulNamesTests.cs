using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeExamples
{
    [TestClass]
    internal class MeaningfulNamesTests
    {
        [TestMethod]
        public void SetDescription_ShouldSetDescription()
        {
            // Arrange
            MeaningfulNames meaningfulNames = new MeaningfulNames();
            string description = "Test Description";

            // Act
            meaningfulNames.SetDescription(description);

            // Assert
            Assert.AreEqual(description, meaningfulNames.GetDescription());
        }

        [TestMethod]
        public void GetDescription_WithoutSetting_ShouldReturnNull()
        {
            // Arrange
            MeaningfulNames meaningfulNames = new MeaningfulNames();

            // Act
            string description = meaningfulNames.GetDescription();

            // Assert
            Assert.IsNull(description);
        }

        [TestMethod]
        public void GetDescription_AfterSetting_ShouldReturnSetDescription()
        {
            // Arrange
            MeaningfulNames meaningfulNames = new MeaningfulNames();
            string description = "New Description";
            meaningfulNames.SetDescription(description);

            // Act
            string retrievedDescription = meaningfulNames.GetDescription();

            // Assert
            Assert.AreEqual(description, retrievedDescription);
        }
    }
}
