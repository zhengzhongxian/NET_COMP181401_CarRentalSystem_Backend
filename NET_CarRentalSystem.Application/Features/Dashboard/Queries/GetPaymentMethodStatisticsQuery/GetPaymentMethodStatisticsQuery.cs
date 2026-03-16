using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetPaymentMethodStatisticsQuery;

public class GetPaymentMethodStatisticsQuery : IQuery<List<PaymentMethodStatisticDto>>;

public class GetPaymentMethodStatisticsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetPaymentMethodStatisticsQuery, List<PaymentMethodStatisticDto>>
{
    public async Task<List<PaymentMethodStatisticDto>> Handle(GetPaymentMethodStatisticsQuery request, CancellationToken cancellationToken)
    {
        var sql = """
            SELECT 
                payment_method AS PaymentMethod,
                COUNT(*) AS Count
            FROM payment_transactions
            WHERE status = 'Success'
            GROUP BY payment_method
            HAVING COUNT(*) > 0
            """;

        var stats = await dapperRepository.QueryAsync<dynamic>(sql, cancellationToken: cancellationToken);
        var statsList = stats.ToList();

        var totalCount = statsList.Sum(x => (int)x.Count);
        
        var result = new List<PaymentMethodStatisticDto>();
        
        if (totalCount == 0) return result;

        result.AddRange(statsList.Select(stat => new PaymentMethodStatisticDto { PaymentMethod = (string)stat.PaymentMethod, Count = (int)stat.Count, Percentage = Math.Round((decimal)stat.Count / totalCount * 100, 2) }));

        return result;
    }
}
