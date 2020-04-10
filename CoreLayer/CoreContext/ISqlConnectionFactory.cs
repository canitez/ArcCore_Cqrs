using System.Data;

namespace CoreLayer.CoreContext
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
