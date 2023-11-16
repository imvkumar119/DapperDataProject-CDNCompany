namespace DapperData.Data
{
    public interface IDataAccess
    {
        Task<IEnumerable<T>> GetData<T, P>(string query, P parameters, string connectionID = "default");
        Task SaveData<P>(string query, P parameters, string connectionID = "default");
    }
}