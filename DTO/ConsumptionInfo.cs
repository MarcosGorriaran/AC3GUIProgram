using CsvHelper.Configuration.Attributes;
using System.Xml.Serialization;

namespace AC3GUIProgram.DTO
{
    [XmlRoot("WaterConsumptionOnCat")]
    public class ConsumptionInfo
    {
        [XmlElement("Any")]
        [Name("Any")]
        public int Year { get; set; }
        [XmlElement("Codi_comarca")]
        [Name("Codi comarca")]
        public int LocCode { get; set; }
        [XmlElement("Comarca")]
        [Name("Comarca")]
        public string LocName { get; set; }
        [XmlElement("Poblacio")]
        [Name("Població")]
        public int Population { get; set; }
        [XmlElement("Domestic_xarxa")]
        [Name("Domèstic xarxa")]
        public int HouseNet { get; set; }
        [XmlElement("Activitats_economicas")]
        [Name("Activitats econòmiques i fonts pròpies")]
        public int EconomicAct { get; set; }
        [XmlElement("Total")]
        [Name("Total")]
        public int Total { get; set; }
        [XmlElement("Consum_domestic_per_capita")]
        [Name("Consum domèstic per càpita")]
        public float HouseExpenseCapita { get; set; }

        public Location GetLocation()
        {
            return new Location()
            {
                LocCode = LocCode,
                LocName = LocName,
            };
        }

        public override string ToString()
        {
            return $"Year: {Year}" + Environment.NewLine +
            $"LocCode: {LocCode}" + Environment.NewLine +
            $"LocName: {LocName}" + Environment.NewLine +
            $"Population: {Population}" + Environment.NewLine +
            $"HouseNet: {HouseNet}" + Environment.NewLine +
            $"EconomicAct: {EconomicAct}" + Environment.NewLine +
            $"Total: {Total}" + Environment.NewLine +
            $"HouseExpenseCapita: {HouseExpenseCapita}" + Environment.NewLine;
        }
    }
}
