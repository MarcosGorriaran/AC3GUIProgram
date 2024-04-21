using AC3GUIProgram.DTO;
using CsvHelper.Configuration;

namespace AC3GUIProgram.Persistance.Mapping
{
    public class ConsumptionInfoCSVMap : ClassMap<ConsumptionInfo>
    {
        public ConsumptionInfoCSVMap()
        {
            Map(col => col.Year).Index(0);
            Map(col => col.LocCode).Index(1);
            Map(col => col.LocName).Index(2);
            Map(col => col.Population).Index(3);
            Map(col => col.HouseNet).Index(4);
            Map(col => col.EconomicAct).Index(5);
            Map(col => col.Total).Index(6);
            Map(col => col.HouseExpenseCapita).Index(7);
        }
    }
}
