using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCounsusAnalyses
{
    public class CsvStateCensuas
    {
        public void ReadStaeCensusData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnylserModel>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                    }
                }
            }
        }
        public void ReadStaeCode(string filePathStateCode)
        {
            using (var reader = new StreamReader(filePathStateCode))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var readRecords = csv.GetRecords<StateCensusAnylserModel>().ToList();
                    foreach (var record in readRecords)
                    {
                        Console.WriteLine($"{record.SrNo} {record.State} {record.Name} {record.TIN} {record.StateCode}");
                    }
                }
            }

        }
    }
}
