using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.TaxCalculator.App.DataModels
{
    public class Schedule24AData
    {
        public Schedule24AData(string particulars)
        {
            Particulars = particulars;
        }
        public string Particulars { get; set; }
        public double Amount { get; set; }
        public double TaxExempted { get; set; }
        public double Taxable => Amount - TaxExempted;
    }

   

}
