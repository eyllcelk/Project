using System;

namespace TariffSelectionApi.Models
{
    /// <summary>
    /// BasicTariff Class 
    /// </summary>
    public class BasicTariff :BaseProduct, ITariffProduct
    {
        public BasicTariff(decimal _baseCost,decimal _additionalKwhCost) 
        {
            BaseCost = _baseCost;
            AdditionalKwhCost = _additionalKwhCost;
        }
        /// <summary>
        /// CalculateAnnualCost for BasicTariff class
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public decimal CalculateAnnualCost(int consumption)
        {
           return BaseCost * 12 + consumption * (AdditionalKwhCost/100);
        }
    }
}
