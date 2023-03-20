using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCounsusAnalyses
{
    public class StateCensusAnylserModel
    {
        public string State { get; set; }
        public string Population { get; set; }
        public string AreaInSqKm { get; set; }
        public string DensityPerSqKm { get; set; }

        //for state code
        public string SrNo { get; set; }
        //public string State { get;set; }
        public string Name { get; set; }
        public string TIN { get; set; }
        public string StateCode { get; set; }
    }
}
//State,Population,AreaInSqKm,DensityPerSqKm
//SrNo,State,Name,TIN,StateCode,


