using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class CSVStates
    {
        public static int ReadStateCodeData(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_NOT_EXISTS,
                    "File not exists");
            }
            if (!Path.GetExtension(filepath).Equals(".csv"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_INCORRECT,
                    "File extension incorrect");
            }
            if (File.ReadAllLines(filepath)[0].Contains("/") || File.ReadAllLines(filepath)[0].Contains("|"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.DELIMITER_INCORRECT,
                    "Delimiter incorrect");
            }
            if (!File.ReadAllLines(filepath)[0].Equals("SrNo,StateName,TIN,StateCode"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.HEADER_INCORRECT,
                    "Header incorrect");
            }
            using (var reader = new StreamReader(filepath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCodeData>().ToList();
                    Console.WriteLine("Read Data from CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.SrNo + "---" + data.StateName + "---" +
                            data.TIN + "---" + data.StateCode);
                    }
                    return records.Count();
                }
            }
        }
    }
}
