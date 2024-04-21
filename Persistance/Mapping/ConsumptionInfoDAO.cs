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
                $" {HouseExpenseCapitaColName}, {IdColName}" +
                $" FROM {ObjectTable} WHERE {IdColName} = @{IdColName}";

            ConsumptionInfo result = new ConsumptionInfo();
            NpgsqlCommand cmd = new NpgsqlCommand(getAllSQL, dbConn);
            cmd.Parameters.AddWithValue(IdColName,id);
            NpgsqlDataReader reader = cmd.ExecuteReader();

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
                $" {HouseExpenseCapitaColName}, {IdColName}" +
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
            const string InsertSQL = $"INSERT INTO {ObjectTable}({YearColName}, {LocCodeColName}, {LocNameColName}," +
                $" {PopColName}, {HouseNetColName}, {EconomicActColName}, {TotalColName}," +
                $" {HouseExpenseCapitaColName})" +
                $" VALUES (@{YearColName}, @{LocCodeColName}, @{LocNameColName}, @{PopColName}," +
                $" @{HouseNetColName}, @{EconomicActColName}, @{TotalColName}, @{HouseExpenseCapitaColName})";
            NpgsqlCommand cmd = new NpgsqlCommand(InsertSQL, dbConn);
            cmd.Parameters.AddWithValue(YearColName, entity.Year);
            cmd.Parameters.AddWithValue(LocCodeColName, entity.LocCode);
            cmd.Parameters.AddWithValue(LocNameColName, entity.LocName);
            cmd.Parameters.AddWithValue(PopColName, entity.Population);
            cmd.Parameters.AddWithValue(HouseNetColName, entity.HouseNet);
            cmd.Parameters.AddWithValue(EconomicActColName, entity.EconomicAct);
            cmd.Parameters.AddWithValue(TotalColName, entity.Total);
            cmd.Parameters.AddWithValue(HouseExpenseCapitaColName, entity.HouseExpenseCapita);

            cmd.ExecuteNonQuery();
        }
        public void Add(IEnumerable<ConsumptionInfo> entities)
        {
            foreach(ConsumptionInfo info in entities)
            {
                Add(info);
            }
        }
        public void Remove(ConsumptionInfo entity)
        {
            const string RemoveSQL = $"DELETE FROM {ObjectTable} WHERE {IdColName}=@{IdColName}";

            NpgsqlCommand cmd = new NpgsqlCommand(RemoveSQL, dbConn);
            cmd.Parameters.AddWithValue(IdColName, entity.id);
        }
        public void Remove(IEnumerable<ConsumptionInfo> entities)
        {
            foreach(ConsumptionInfo entity in entities)
            {
                Remove(entity);
            }
        }
        public void Update(ConsumptionInfo entity)
        {
            const string UpdateSQL = $"UPDATE {ObjectTable} SET {YearColName}=@{YearColName}, {LocCodeColName}=@{LocCodeColName}, {LocNameColName}=@{LocNameColName}," +
                $" {PopColName}=@{PopColName}, {HouseNetColName}=@{HouseNetColName}, {EconomicActColName}=@{EconomicActColName}, {TotalColName}=@{TotalColName}, {HouseExpenseCapitaColName}=@{HouseExpenseCapitaColName}" +
                $" WHERE {IdColName}=@{IdColName}";
            NpgsqlCommand cmd = new NpgsqlCommand(UpdateSQL, dbConn);

            cmd.Parameters.AddWithValue(YearColName, entity.Year);
            cmd.Parameters.AddWithValue(LocCodeColName, entity.LocCode);
            cmd.Parameters.AddWithValue(LocNameColName, entity.LocName);
            cmd.Parameters.AddWithValue(PopColName, entity.Population);
            cmd.Parameters.AddWithValue(HouseNetColName, entity.HouseNet);
            cmd.Parameters.AddWithValue(EconomicActColName, entity.EconomicAct);
            cmd.Parameters.AddWithValue(TotalColName, entity.Total);
            cmd.Parameters.AddWithValue(HouseExpenseCapitaColName, entity.HouseExpenseCapita);

            cmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            dbConn.Close();
        }
    }
}
