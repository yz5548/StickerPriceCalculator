using Microsoft.VisualStudio.TestTools.UnitTesting;
using StickerPriceCalculator.WebAPI.Controllers;
using StickerPriceCalculator.Interfaces;
using StickerPriceCalculator.Entity;

namespace StickerPriceCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IStickerPriceCalculator iStickerPriceCalculator = new StickPriceCalculator.BLL.StickPriceCalculator();

            var controller = new StickerPriceCalculatorController(iStickerPriceCalculator);
            decimal startEPS = -1.36m;// for example, RH has EPS=-1.36 in 2013
            decimal EPSTTM = 2.16m;// for example , RH has trailing twelve month EPS for 2.16 in 2017 June
            int years = 3; //2013,2014,2015,2016 , that's N(4) - 1 = 3 years.
            double MinimalAcceptableGrowthRate = 0.15;// that means MinimalAcceptableGrowthRate=15%;

            ResultParameters testedResult = controller.CalculateStockPrice(startEPS, EPSTTM, years, MinimalAcceptableGrowthRate);

            ResultParameters targetResultParameter = new ResultParameters();
            targetResultParameter.StickerPrice = 64.80m;
            targetResultParameter.MarginOfSafety = 32.40m;

            Assert.AreEqual(testedResult.MarginOfSafety, targetResultParameter.MarginOfSafety);
            Assert.AreEqual(testedResult.StickerPrice, targetResultParameter.StickerPrice);

        }
    }
}
