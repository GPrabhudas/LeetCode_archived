/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var minprice = Number.MAX_VALUE;
    var maxprofit = 0;
    for(var i=0;i<prices.length;i++){
        if(prices[i] < minprice){
            minprice = prices[i];
        }else if(prices[i] - minprice > maxprofit){
            maxprofit = prices[i] - minprice;
        }
    }
    return maxprofit;
};
