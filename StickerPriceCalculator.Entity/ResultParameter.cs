using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Entity
{
    public class ResultParameters
    {
        private decimal stickerPrice;// { get; set; }
        private decimal marginOfSafety;// { get; set; }

        public decimal StickerPrice
        {
            get
            {
                return Math.Round(stickerPrice,2);
            }

            set
            {
                stickerPrice = value;
            }
        }

        public decimal MarginOfSafety
        {
            get
            {
                return Math.Round( marginOfSafety,2);
            }

            set
            {
                marginOfSafety = value;
            }
        }
    }

    
}
