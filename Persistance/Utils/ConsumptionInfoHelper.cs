using AC3GUIProgram.DTO;

namespace AC3GUIProgram.Persistance.Utils
{
    public static class ConsumptionInfoHelper
    {
        public static bool HasHighPop(ConsumptionInfo info, int popLimitCond)
        {
            return info.Population > popLimitCond;
        }
        public static int GetAvgDomesticConsum(ConsumptionInfo info)
        {
            Dictionary<string, float> keyValuePairs = CRUD.GetAvarage(new List<ConsumptionInfo>() { info }, info => info.LocName, info => info.HouseExpenseCapita, info => info.LocName);

            return Convert.ToInt32(keyValuePairs.First().Value);
        }
        public static bool IsHighestCapita(int index, List<ConsumptionInfo> info)
        {
            return info[index].HouseExpenseCapita >= info.Max(info => info.HouseExpenseCapita);
        }
        public static bool IsLowestCapita(int index, List<ConsumptionInfo> info)
        {
            return info[index].HouseExpenseCapita <= info.Min(info => info.HouseExpenseCapita);
        }
    }
}
