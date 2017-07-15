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
            ResultParameters testedResult = controller.CalculateStockPrice(-1.36m,2.16m,3,0.15);
            Assert.AreEqual(testedResult, new ResultParameters());

        }
    }
}
