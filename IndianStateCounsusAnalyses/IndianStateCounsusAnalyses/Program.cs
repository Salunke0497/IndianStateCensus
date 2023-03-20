using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCounsusAnalyses
{
    internal class Program
    {
        public static string filePath = @"D:\BATCH-256\indian\IndianStateCounsusAnalyses\IndianStateCounsusAnalyses\files\StateCensusData.csv";
        public static string filePathStateCode = @"D:\BATCH-256\indian\IndianStateCounsusAnalyses\IndianStateCounsusAnalyses\files\StateCodeCheck.csv";

        static void Main(string[] args)
        {
            CsvStateCensuas stateCensusAnylserModel = new CsvStateCensuas();
            stateCensusAnylserModel.ReadStaeCensusData(filePath);
            stateCensusAnylserModel.ReadStaeCode(filePathStateCode);
            Console.ReadLine();
        }
        
    }
}
