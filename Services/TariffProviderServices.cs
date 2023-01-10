using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TariffSelectionApi.Models;
using System.Linq;
using TariffSelectionApi.Interfaces;


namespace TariffSelectionApi.Services
{
    public class TariffProviderServices : ITariffProvider
    {
        /// <summary>
        /// Get/Read list of Tariff providers from json file
        /// </summary>
        /// <returns></returns>
        public List<BaseProduct> GetListOfTariffProviders()
        {

            using (StreamReader r = new StreamReader("TariffProvider.json"))
            {
                string json = r.ReadToEnd();

                return JsonConvert.DeserializeObject<List<BaseProduct>>(json);
            }

        }
        /// <summary>
        /// Get ordered list of tariff providers with annual cost according to consumption 
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public List<BaseProduct> GetListOfTariffProvidersWithCons(int consumption)
        {
            ProductFactory factory = new ConcreteProductFactory();
            var tarifs = GetListOfTariffProviders();
            tarifs.ForEach(item => item.AnnualCost= factory.GetProduct(item).CalculateAnnualCost(consumption));
            return tarifs.OrderBy(x => x.AnnualCost).ToList();
        }
    }
}
