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
    /// <summary>
    /// Controller used to Calculate StickerPrice
    /// </summary>
    public class StickerPriceCalculatorController : ApiController
    {
        private readonly IStickerPriceCalculator _stickerPriceCalculator;


        /// <summary>
        /// constructor function
        /// </summary>
        /// <param name="stickerPriceCalculator"></param>
        public StickerPriceCalculatorController(IStickerPriceCalculator stickerPriceCalculator)
        {
            _stickerPriceCalculator = stickerPriceCalculator;
        }


        /// <summary>
        /// CalculateStockPrice
        /// </summary>
        /// <param name="StartEarningPerShare">for example, RH has EPS=-1.36 in 2013</param>
        /// <param name="EarningPerShareTTM">for example , RH has EPS = 2.16 in 2016</param>
        /// <param name="IntervalYears">2013,2014,2015,2016 , that's N(4) - 1 = 3 years.</param>
        /// <param name="MinimalAcceptableGrowthRate">that means MinimalAcceptableGrowthRate=15%</param>
        /// <returns></returns>
        public ResultParameters CalculateStockPrice(decimal StartEarningPerShare, decimal EarningPerShareTTM, int IntervalYears, double MinimalAcceptableGrowthRate = 0.15)
        {
            InputParameters inputParameters = new InputParameters(StartEarningPerShare, EarningPerShareTTM, IntervalYears, MinimalAcceptableGrowthRate);
            ResultParameters result = _stickerPriceCalculator.CalculateStickPrice(inputParameters);
            return result;
        }

        

    }
}
