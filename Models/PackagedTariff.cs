using System;

namespace TariffSelectionApi.Models
{
    public class PackagedTariff :BaseProduct, ITariffProduct
    {
       /// <summary>
       /// PackagedTariff Class
       /// </summary>
       /// <param name="_baseCost"></param>
       /// <param name="_additionalKwhCost"></param>
       /// <param name="_includedKwh"></param>
        public PackagedTariff(decimal _baseCost, decimal _additionalKwhCost,int _includedKwh)
        {
            BaseCost = _baseCost;
            AdditionalKwhCost = _additionalKwhCost;
            IncludedKwh = _includedKwh;
        }
        /// <summary>
        /// CalculateAnnualCost for PackagedTariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public decimal CalculateAnnualCost(int consumption)
        {
            return consumption <= IncludedKwh ? BaseCost : (BaseCost + ((consumption - IncludedKwh) * (AdditionalKwhCost / 100)));
        }
    }
}
