using System;
using TariffSelectionApi.Enums;

namespace TariffSelectionApi.Models
{
    /// <summary>
    /// Base product Class
    /// </summary>
    public class BaseProduct
    {

        #region PrivateMember
        private string _name;
        private TypeOfTariff _type;
        private decimal _baseCost;
        private decimal _additionalKwhCost;
        private int _includedKwh;
        private decimal _annualCost;
        #endregion

        #region PublicMember
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public TypeOfTariff Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public decimal BaseCost
        {
            get
            {
                return _baseCost;
            }
            set
            {
                _baseCost = value;
            }
        }
        
        public decimal AdditionalKwhCost
        {
            get
            {
                return _additionalKwhCost;
            }
            set
            {
                _additionalKwhCost = value;
            }
        }
        public int IncludedKwh
        {
            get
            {
                return _includedKwh;
            }
            set
            {
                _includedKwh = value;
            }
        }
        public decimal AnnualCost
        {
            get
            {
                return _annualCost;
            }
            set
            {
                _annualCost = value;
            }
        }
        #endregion
        public BaseProduct()
        {

        }
    }
}
