using ReportScData.Data;
using Microsoft.EntityFrameworkCore;
namespace ReportScData.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly ScDataContext _context;

        public ReportRepository(ScDataContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Report>> GetReports()
        {
            return await _context.Reports.ToListAsync();
        }
    }
}
