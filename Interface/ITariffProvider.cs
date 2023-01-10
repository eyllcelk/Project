using System;
using System.Collections.Generic;
using TariffSelectionApi.Models;

namespace TariffSelectionApi.Interfaces
{
    public interface ITariffProvider
    {
        List<BaseProduct> GetListOfTariffProviders();
        List<BaseProduct> GetListOfTariffProvidersWithCons(int consumption);
    }
}
