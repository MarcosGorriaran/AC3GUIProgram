using AC3GUIProgram.DTO;
using Npgsql;

namespace AC3GUIProgram.Persistance.Utils
{
    public static class NpgsqlUtils
    {
        public static ConsumptionInfo GetConsumptionInfo(NpgsqlDataReader reader)
        {
            ConsumptionInfo result = new ConsumptionInfo()
            {
                Year = reader.GetInt32(0),
                LocCode = reader.GetInt32(1),
                LocName = reader.GetString(2),
                Population = reader.GetInt32(3),
                HouseNet = reader.GetInt32(4),
                EconomicAct = reader.GetInt32(5),
                Total = reader.GetInt32(6),
                HouseExpenseCapita = reader.GetFloat(7),
                id = reader.GetInt32(8)
            };
            return result;
        }
    }
}
