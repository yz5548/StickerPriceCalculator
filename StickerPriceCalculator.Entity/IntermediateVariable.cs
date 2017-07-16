using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Entity
{

    public class IntermediateVariable
    {
        public decimal FutureEarningPerShare { get; set; }

        public decimal FutureStockPrice { get; set; }

        public double FuturePE { get; set; }

        public double FutureGrowthRate { get; set; }
    }

}
