using my_book_training_api.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace my_book_training_api.Data.Services
{
    public class LogsService
    {
        private AppDbContext _context;
        public LogsService(AppDbContext context)
        {
            _context = context;
        }

        public List<Log> GetAllLogsFromDB() => _context.Logs.ToList();
    }
}
