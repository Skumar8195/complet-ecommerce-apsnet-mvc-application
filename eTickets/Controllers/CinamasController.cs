using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinamasController : Controller
    {
        private readonly AppDbContext _context;
        public CinamasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinamas = await _context.Cinemas.ToListAsync();
            return View(allCinamas);
        }
    }
}
