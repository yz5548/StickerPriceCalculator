using StickerPriceCalculator.Entity;
using StickerPriceCalculator.Interfaces;

namespace StickPriceCalculator.BLL
{
    public class StickPriceCalculator: IStickerPriceCalculator
    {
        
        public ResultParameters CalculateStickPrice(InputParameters inputParameter)
        {
            IntermediateVariable intermediateVariable = new IntermediateVariable();
            ResultParameters resultParameters = CalculateIntermediateVariable(intermediateVariable);
            return resultParameters;
        }

        #region private method
        private IntermediateVariable CalculateIntermediateVariable(InputParameters inputParameter)
        {
            //todo 
            return null;
        }

        private ResultParameters CalculateIntermediateVariable(IntermediateVariable intermediateVariable)
        {

            //todo 
            return null;
        }
        #endregion

    }
}
