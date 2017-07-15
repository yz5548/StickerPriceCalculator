using StickerPriceCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Interfaces
{
    public interface IStickerPriceCalculator
    {
        ResultParameters CalculateStickPrice(InputParameters inputParameter);
    }
}
