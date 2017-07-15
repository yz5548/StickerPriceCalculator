using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Entity
{

    public class IntermediateVariable
    {
        decimal FutureEarningPerShare { get; set; }

        decimal FutureStockPrice { get; set; }

        double FuturePE { get; set; }

        double FutureGrowthRate { get; set; }
    }

}
