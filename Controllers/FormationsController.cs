using Microsoft.AspNetCore.Mvc;
using dotnet_portfolio_api.Models;
using dotnet_portfolio_api.Data;

namespace dotnet_portfolio_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormationsController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public FormationsController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Formation>> GetFormations()
        {
            return _context.Formations.ToList();
        }
    }
}