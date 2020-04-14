using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.SampleProduct.Query.Model;
using Core.CoreContext;
using Dapper;
using MediatR;

namespace Application.SampleProduct.Query.Business
{
    internal class GetCustomerOrdersQueryHandler : IRequestHandler<GetSampleProduct, List<GetSampleProduct>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetCustomerOrdersQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<List<GetSampleProduct>> Handle(GetSampleProduct request, CancellationToken cancellationToken)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();

            const string sql = "SELECT " +
                               "[Order].[Id], " +
                               "[Order].[IsRemoved], " +
                               "[Order].[Value], " +
                               "[Order].[Currency] " +
                               "FROM orders.v_Orders AS [Order] " +
                               "WHERE [Order].CustomerId = @CustomerId";
            var orders = await connection.QueryAsync<GetSampleProduct>(sql, new { request.SampleProductId });

            return orders.AsList();
        }

    }
}
