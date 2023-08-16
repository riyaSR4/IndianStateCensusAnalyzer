using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class CSVStateCensus
    {
        public static int ReadStateCensusData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusData>().ToList();
                    return records.Count() - 1;
                }
            }
        }
    }
}
