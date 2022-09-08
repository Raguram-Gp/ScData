using ReportScData.Data;

namespace ReportScData.Repository
{
    public interface IReportRepository
    {
        Task<IEnumerable<Report>> GetReports();
    }
}
