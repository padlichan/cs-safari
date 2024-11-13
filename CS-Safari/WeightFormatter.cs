using System.Globalization;
using System.Security.Cryptography;

namespace CS_Safari
{
    public class WeightFormatter : IFormattable
    {
        private Animal animal;
        IFormatProvider formatProvider;
        private string format;
        private double weightToReturn;
        WeightUnitType weightUnitType;

        public WeightFormatter(Animal animal,WeightUnitType weightUnitType ,IFormatProvider formatProvider)
        {
            this.animal = animal;
            this.formatProvider = formatProvider;
            this.weightUnitType = weightUnitType;
            switch (weightUnitType)
            {
                case WeightUnitType.kilogram:
                    format = "N1";
                    weightToReturn = animal.Weight;
                    break;
                case WeightUnitType.ounce:
                    format = "N2";
                    weightToReturn = animal.Weight*35.274;
                    break;
                default:
                    format = "N1";
                    weightToReturn = animal.Weight;
                    break;

            }
        }

        public WeightFormatter(Animal animal)
        {
            this.animal = animal;
            formatProvider = CultureInfo.CurrentCulture;
            this.weightToReturn = animal.Weight;
            this.weightUnitType = WeightUnitType.kilogram;
            format = "N1";
        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            format = this.format;
            formatProvider = this.formatProvider;
            return $"This {animal.GetType().Name}'s weight is {weightToReturn.ToString(format, formatProvider)} {weightUnitType}s.";

        }
    }

    public enum WeightUnitType 
    {
        kilogram,
        ounce
    }
}

