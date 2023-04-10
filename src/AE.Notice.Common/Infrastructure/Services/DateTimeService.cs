using AE.Notice.Common.Application.Common.Interface;

namespace AE.Notice.Common.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}