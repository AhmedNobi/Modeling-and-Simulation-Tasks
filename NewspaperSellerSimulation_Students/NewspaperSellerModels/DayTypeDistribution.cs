using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public DayTypeDistribution(Enums.DayType DayType_, decimal Probability_)
        {
            this.DayType = DayType_;
            this.Probability = Probability_;
        }
        public DayTypeDistribution()
        {
            this.MinRange = 0;
            this.MaxRange = 0;
            this.Probability = 0;
            this.CummProbability = 0;
        }
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        
    }
}
