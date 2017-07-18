using Microsoft.VisualBasic;
using StickerPriceCalculator.Entity;
using StickerPriceCalculator.Interfaces;
using System;

namespace StickerPriceCalculator.BLL
{
    public class StickerPriceCalculator: IStickerPriceCalculator
    {
        
        public ResultParameters CalculateStickPrice(InputParameters inputParameter)
        {
            IntermediateVariable intermediateVariable = new IntermediateVariable();
            intermediateVariable = CalculateIntermediateVariable(inputParameter);
            ResultParameters resultParameters = CalculateIntermediateVariable(intermediateVariable);
            return resultParameters;
        }

        #region private method
        private IntermediateVariable CalculateIntermediateVariable(InputParameters inputParameter)
        {
            IntermediateVariable intermediateVariable = new IntermediateVariable();
            //Future Growth Rate
            double futureGrowthRate = Financial.Rate(inputParameter.IntervalYears,0,(double)inputParameter.StartEarningPerShare,(double)inputParameter.EarningPerShaereTrailingTwelveMonths);
            if (futureGrowthRate > 0.15 && futureGrowthRate <= 1)
                intermediateVariable.FutureGrowthRate = 0.15;
            else if (futureGrowthRate >= 0 && futureGrowthRate <= 0.15)
                intermediateVariable.FutureGrowthRate = futureGrowthRate;
            else
                throw new ArgumentOutOfRangeException("FutureGrowthRate should be in range [0,1]");


            //futurePE
            double futurePE = intermediateVariable.FutureGrowthRate * 2;
            intermediateVariable.FuturePE = futurePE;

            //Future EPS
            double pv;//if inputParameter.StartEarningPerShare=1.43$;  pv=-1.43
            if (inputParameter.EarningPerShaereTrailingTwelveMonths > 0)
                pv = -(double)inputParameter.EarningPerShaereTrailingTwelveMonths;
            else
                pv= (double)inputParameter.EarningPerShaereTrailingTwelveMonths;
            double futureEPS = Financial.FV(intermediateVariable.FutureGrowthRate, 10.0, 0.0, pv);
            intermediateVariable.FutureEarningPerShare= (decimal)futureEPS;


            //Future Stock Price
            double futureStockPrice = futureEPS * futurePE * 100;
            intermediateVariable.FutureStockPrice = (decimal)futureStockPrice;


            return intermediateVariable;
        }

        private ResultParameters CalculateIntermediateVariable(IntermediateVariable intermediateVariable)
        {
            ResultParameters resultParameter = new ResultParameters();
            resultParameter.StickerPrice = (decimal)Financial.PV(intermediateVariable.FutureGrowthRate,10,0,-(double)intermediateVariable.FutureStockPrice);
            resultParameter.MarginOfSafety = resultParameter.StickerPrice / 2.0m;
            return resultParameter;
        }
        #endregion

    }
}
