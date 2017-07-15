using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPriceCalculator.Entity
{
    public class InputParameters
    {
        public InputParameters(decimal _StartEarningPerShare,decimal _EarningPerShareTrailingTwelveMonths, int _IntervalYears, double _MinimalAcceptableGrowthRate = 15.0)
        {
            StartEarningPerShare = _StartEarningPerShare;
            EarningPerShaereTrailingTwelveMonths = _EarningPerShareTrailingTwelveMonths;
            IntervalYears = _IntervalYears;
            MinimalAcceptableGrowthRate = _MinimalAcceptableGrowthRate;
        }

        decimal StartEarningPerShare { get; set; }

        decimal EarningPerShaereTrailingTwelveMonths { get; set; }


        /// <summary>
        /// range: [0 - 0.15]
        /// </summary>
        public double MinimalAcceptableGrowthRate
        {
            get
            {
                return minimalAcceptableGrowthRate;
            }

            set
            {
                minimalAcceptableGrowthRate = value;
            }
        }

        
        double minimalAcceptableGrowthRate = 0.15;


        /// <summary>
        /// 举例: 初始EPS在2014年, EPSTTM在2016年;即，共包括：2014，2015，2016三年，IntervalYears = 3
        /// </summary>
        int IntervalYears { get; set; }

    }
}
