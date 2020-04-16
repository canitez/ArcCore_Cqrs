using System.Data;

namespace Core.CoreContext
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
