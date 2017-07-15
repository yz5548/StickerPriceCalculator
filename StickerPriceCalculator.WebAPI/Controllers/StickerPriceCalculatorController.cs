using StickerPriceCalculator.Entity;
using StickerPriceCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StickerPriceCalculator.WebAPI.Controllers
{
    public class StickerPriceCalculatorController : ApiController
    {
        private IStickerPriceCalculator _stickerPriceCalculator;

        public StickerPriceCalculatorController(IStickerPriceCalculator stickerPriceCalculator)
        {
            _stickerPriceCalculator = stickerPriceCalculator;
        }

        public ResultParameters CalculateStockPrice(decimal StartEarningPerShare, decimal EarningPerShareTTM, int IntervalYears, double MinimalAcceptableGrowthRate = 0.15)
        {
            InputParameters inputParameters = new InputParameters(StartEarningPerShare, EarningPerShareTTM, IntervalYears, MinimalAcceptableGrowthRate);
            ResultParameters result = _stickerPriceCalculator.CalculateStickPrice(inputParameters);
            return result;
        }

    }
}
