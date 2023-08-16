﻿using CsvHelper;
using System.Globalization;

namespace IndianStateCensusAnalyzer
{
    public class StateCensusAnalyzer
    {
        public static int ReadStateCensusData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusData>().ToList();
                    Console.WriteLine("Read Data from CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.State + "---" + data.Population + "---" + 
                            data.AreaInSqKm + "---" + data.DensityPerSqKm);
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}