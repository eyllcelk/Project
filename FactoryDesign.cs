using System;
using TariffSelectionApi.Enums;
using TariffSelectionApi.Models;

namespace TariffSelectionApi
{
    /// <summary>
    /// common method interface
    /// </summary>
    public interface ITariffProduct
    {
        public decimal CalculateAnnualCost(int consumption);
    }
    
    /// <summary>
    ///  The creator abstract class and abstract method
    /// </summary>
    public abstract class ProductFactory
    {
        public abstract ITariffProduct GetProduct(BaseProduct product);

    }

    /// <summary>
    /// ConcreteCreator class
    /// </summary>
    public class ConcreteProductFactory : ProductFactory
    {
        public override ITariffProduct GetProduct(BaseProduct product)
        {
            switch (product.Type)
            {
                case TypeOfTariff.BasicElectricty:
                    return new BasicTariff(product.BaseCost,product.AdditionalKwhCost);
                case TypeOfTariff.PackageTariff:
                    return new PackagedTariff(product.BaseCost,product.AdditionalKwhCost,product.IncludedKwh);
                default:
                    throw new ApplicationException(string.Format("Product '{0}' cannot be created",product.Type ));
            }
        }

    }

}