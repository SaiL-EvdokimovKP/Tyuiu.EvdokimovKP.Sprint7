using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.V13.Lib;

namespace Project.V13.Tests
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void PopulationAnalyzer_FindMinMaxPopulation_ValidData_ReturnsCorrectValues()
        {
            // Arrange
            int[] population = { 144_100_000, 331_000_000, 67_000_000 };
            string[] countries = { "Россия", "США", "Франция" };

            // Act
            var result = DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);

            // Assert
            Assert.AreEqual("США", result.maxCountry);
            Assert.AreEqual(331_000_000, result.maxPopulation);
            Assert.AreEqual("Франция", result.minCountry);
            Assert.AreEqual(67_000_000, result.minPopulation);
        }

        [TestMethod]
        public void PopulationAnalyzer_FindMinMaxPopulation_SingleElement_ReturnsSameValues()
        {
            // Arrange
            int[] population = { 144_100_000 };
            string[] countries = { "Россия" };

            // Act
            var result = DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);

            // Assert
            Assert.AreEqual("Россия", result.maxCountry);
            Assert.AreEqual(144_100_000, result.maxPopulation);
            Assert.AreEqual("Россия", result.minCountry);
            Assert.AreEqual(144_100_000, result.minPopulation);
        }

        [TestMethod]
        public void PopulationAnalyzer_FindMinMaxPopulation_AllSameValues_ReturnsFirstElement()
        {
            // Arrange
            int[] population = { 100, 100, 100 };
            string[] countries = { "A", "B", "C" };

            // Act
            var result = DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);

            // Assert
            Assert.AreEqual("A", result.maxCountry);
            Assert.AreEqual(100, result.maxPopulation);
            Assert.AreEqual("A", result.minCountry);
            Assert.AreEqual(100, result.minPopulation);
        }

        [TestMethod]
        public void PopulationAnalyzer_GetPopulationAnalysisReport_ValidData_ReturnsCorrectFormat()
        {
            // Arrange
            int[] population = { 144_100_000, 331_000_000 };
            string[] countries = { "Россия", "США" };

            // Act
            string report = DataService.PopulationAnalyzer.GetPopulationAnalysisReport(population, countries);

            // Assert
            string expected = "Страна с максимальным населением: США - 331000000 чел.\n" +
                              "Страна с минимальным населением: Россия - 144100000 чел.";
            Assert.AreEqual(expected, report);
        }

        [TestMethod]
        public void AnalyzerS_FindMinMaxS_ValidData_ReturnsCorrectValues()
        {
            // Arrange
            int[] areas = { 17_100_000, 9_834_000, 643_801 };
            string[] countries = { "Россия", "Китай", "Франция" };

            // Act
            var result = DataService.AnalyzerS.FindMinMaxS(areas, countries);

            // Assert
            Assert.AreEqual("Россия", result.maxCountry);
            Assert.AreEqual(17_100_000, result.maxS);
            Assert.AreEqual("Франция", result.minCountry);
            Assert.AreEqual(643_801, result.minS);
        }

        [TestMethod]
        public void AnalyzerS_FindMinMaxS_NegativeValues_HandlesCorrectly()
        {
            // Arrange
            int[] areas = { -100, -50, -200 };
            string[] countries = { "A", "B", "C" };

            // Act
            var result = DataService.AnalyzerS.FindMinMaxS(areas, countries);

            // Assert
            Assert.AreEqual("B", result.maxCountry);  // -50 is max among negatives
            Assert.AreEqual(-50, result.maxS);
            Assert.AreEqual("C", result.minCountry);  // -200 is min among negatives
            Assert.AreEqual(-200, result.minS);
        }

        [TestMethod]
        public void AnalyzerS_GetSAnalysisReport_ValidData_ReturnsCorrectFormat()
        {
            // Arrange
            int[] areas = { 17_100_000, 9_834_000 };
            string[] countries = { "Россия", "Китай" };

            // Act
            string report = DataService.AnalyzerS.GetSAnalysisReport(areas, countries);

            // Assert
            string expected = "Страна с максимальной площадью: Россия - 17100000 км²\n" +
                              "Страна с минимальной площадью: Китай - 9834000 км²";
            Assert.AreEqual(expected, report);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void FindMinMaxPopulation_EmptyArrays_ThrowsException()
        {
            // Arrange
            int[] population = { };
            string[] countries = { };

            // Act
            DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void FindMinMaxS_EmptyArrays_ThrowsException()
        {
            // Arrange
            int[] areas = { };
            string[] countries = { };

            // Act
            DataService.AnalyzerS.FindMinMaxS(areas, countries);
        }

        [TestMethod]
        public void BothAnalyzers_SameCountryForMaxAndMin_WhenArraysContainSingleElement()
        {
            // Arrange
            int[] data = { 100 };
            string[] countries = { "Единственная" };

            // Act
            var populationResult = DataService.PopulationAnalyzer.FindMinMaxPopulation(data, countries);
            var areaResult = DataService.AnalyzerS.FindMinMaxS(data, countries);

            // Assert
            Assert.AreEqual("Единственная", populationResult.maxCountry);
            Assert.AreEqual("Единственная", populationResult.minCountry);
            Assert.AreEqual("Единственная", areaResult.maxCountry);
            Assert.AreEqual("Единственная", areaResult.minCountry);
        }
    }
}