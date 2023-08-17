using IndianStateCensusAnalyzer;

namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath), 
                CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));
        }
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            } 
        }
        [Test]
        public void GivenStateCensusDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }
        }
        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
    }
}