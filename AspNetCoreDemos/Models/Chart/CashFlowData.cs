using System;

namespace AspNetCoreDemos.Models
{
    public class CashFlowData
    {
        public string Period { get; set; }
        public decimal? Amount { get; set; }
        public string Summary { get; set; }
    }
}