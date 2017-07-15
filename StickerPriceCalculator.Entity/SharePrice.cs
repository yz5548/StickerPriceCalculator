using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Entity
{
    public class SharePrice
    {
        /// <summary>
        /// 美东时间的当日收盘时间;
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 当个交易日收盘价
        /// </summary>
        public decimal Price { get; set; }
    }
}
