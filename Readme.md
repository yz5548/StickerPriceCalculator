StickPriceCalculator is used to calculate Sticker price for Stock in USA.

Sticker price is a price that stock worth.
Margin of Safety is a price 50% of sticker price, which is a suitable price to buy the stock.

Given enough parameter, including 
            decimal startEPS = -1.36m;// for example, RH has EPS=-1.36 in 2014
            decimal EPSTTM = 2.16m;// for example , RH has trailing twelve month EPS for 2.16 in 2017 June
            int years = 3; //2014,2015,2016 , that's 3 years.
            double MinimalAcceptableGrowthRate = 0.15;// that means MinimalAcceptableGrowthRate=15%;
            
Then, you can get sticker price and margin of safety using this webapi

TestAPI:
http://218.244.141.45:20178/api/StickerPriceCalculator/CalculateStockPrice/?StartEarningPerShare=-1.36&EarningPerShareTTM=2.16&IntervalYears=3