using IndianStateCensusAnalyzer;

namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.csv";
        public string stateCensusDataIncorrectFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.txt";
        public string stateCensusDataNoFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensus.csv";
        public string stateCensusDataHeaderFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusDataHeader.csv";
        public string stateCensusDataDelimiterFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusDataDelimiter.csv";

        public string stateCodeFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCode.csv";
        public string stateCodeIncorrectFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCode.txt";
        public string stateCodeNoFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCodeData.csv";
        public string stateCodeHeaderFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCodeHeader.csv";
        public string stateCodeDelimiterFilePath = @"D:\BridgeLabs Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCodeDelimiter.csv";
        
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
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataIncorrectFilePath);
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
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataNoFilePath);
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
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataHeaderFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Header incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDataFileDelimiterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataDelimiterFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter incorrect");
            }
        }

        [Test]
        public void GivenStateCode_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(CSVStates.ReadStateCodeData(stateCodeFilePath),37);
        }
        [Test]
        public void GivenStateCodeFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                CSVStates.ReadStateCodeData(stateCodeIncorrectFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }
        }
        [Test]
        public void GivenStateCodeFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                CSVStates.ReadStateCodeData(stateCodeNoFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }
        }
        [Test]
        public void GivenStateCodeFileHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                CSVStates.ReadStateCodeData(stateCodeHeaderFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Header incorrect");
            }
        }
        [Test]
        public void GivenStateCodeFileDelimiterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                CSVStates.ReadStateCodeData(stateCodeDelimiterFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter incorrect");
            }
        }
    }
}