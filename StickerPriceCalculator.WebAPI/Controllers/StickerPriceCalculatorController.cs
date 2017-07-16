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

   

        /// <summary>
        /// http://localhost/StickerPriceCalculator.WebAPI/api/StickerPriceCalculator/CalculateStockPrice/?StartEarningPerShare=-1.36&EarningPerShareTTM=2.16&IntervalYears=3
        /// </summary>
        /// <param name="StartEarningPerShare"></param>
        /// <param name="EarningPerShareTTM"></param>
        /// <param name="IntervalYears"></param>
        /// <param name="MinimalAcceptableGrowthRate"></param>
        /// <returns></returns>
        [HttpGet]
        public ResultParameters CalculateStockPrice(decimal StartEarningPerShare, decimal EarningPerShareTTM, int IntervalYears, double MinimalAcceptableGrowthRate = 0.15)
        {
            InputParameters inputParameters = new InputParameters(StartEarningPerShare, EarningPerShareTTM, IntervalYears, MinimalAcceptableGrowthRate);
            ResultParameters result = _stickerPriceCalculator.CalculateStickPrice(inputParameters);
            return result;
        }

    }
}
