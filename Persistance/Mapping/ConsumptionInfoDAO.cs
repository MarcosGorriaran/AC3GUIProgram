using AC3GUIProgram.DTO;
using AC3GUIProgram.Persistance.DAO;
using AC3GUIProgram.Persistance.Utils;
using Npgsql;

namespace AC3GUIProgram.Persistance.Mapping
{
    public class ConsumptionInfoDAO : IDisposable, IDAO<ConsumptionInfo>
    {
        private readonly NpgsqlConnection dbConn;
        const string ObjectTable = "consumptioninfo",
        IdColName = "id",
        YearColName = "year",
        LocCodeColName = "locationcode",
        LocNameColName = "locationname",
        PopColName = "population",
        HouseNetColName = "housenet",
        EconomicActColName = "economicactivity",
        TotalColName = "total",
        HouseExpenseCapitaColName = "houseexpensecapita";

        private ConsumptionInfoDAO(string connectionString)
        {
            dbConn = new NpgsqlConnection(connectionString);
        }
        public ConsumptionInfoDAO() : this(ConfigurationHelper.GetConnectionString())
        {

        }

        public ConsumptionInfo GetById<T>(T id)
        {
            string getAllSQL = $"SELECT {YearColName}, {LocCodeColName}, {LocNameColName}," +
                $" {PopColName}, {HouseNetColName}, {EconomicActColName}, {TotalColName}," +
                $" {HouseExpenseCapitaColName}" +
                $" FROM {ObjectTable} WHERE {IdColName} = {id}";

            ConsumptionInfo result = new ConsumptionInfo();
            NpgsqlDataReader reader = new NpgsqlCommand(getAllSQL, dbConn).ExecuteReader();

            if (reader.Read())
            {
                result = NpgsqlUtils.GetConsumptionInfo(reader);
            }
            return result;
        }
        public IEnumerable<ConsumptionInfo> GetAll()
        {
            const string GetAllSQL = $"SELECT {YearColName}, {LocCodeColName}, {LocNameColName}," +
                $" {PopColName}, {HouseNetColName}, {EconomicActColName}, {TotalColName}," +
                $" {HouseExpenseCapitaColName}" +
                $" FROM "+ObjectTable;

            List<ConsumptionInfo> result = new List<ConsumptionInfo>();
            NpgsqlDataReader reader = new NpgsqlCommand(GetAllSQL, dbConn).ExecuteReader();

            while (reader.Read())
            {
                result.Add(NpgsqlUtils.GetConsumptionInfo(reader));
            }
            return result;
        }
        public void Add(ConsumptionInfo entity)
        {

        }
        public void Add(IEnumerable<ConsumptionInfo> entities)
        {

        }
        public void Remove(ConsumptionInfo entity)
        {

        }
        public void Remove(IEnumerable<ConsumptionInfo> entities)
        {

        }
        public void Update(ConsumptionInfo entity)
        {

        }

        public void Dispose()
        {
            dbConn.Close();
        }
    }
}
