using Microsoft.AspNetCore.Mvc;
using dotnet_portfolio_api.Models;
using dotnet_portfolio_api.Data;

namespace dotnet_portfolio_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompetencesController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public CompetencesController(PortfolioContext context)
        {
            _context = context;

            // Si aucune compétence ajoutée
            if (!_context.Competences.Any())
            {
                _context.Competences.AddRange(
                    new Competence { Nom = "Aucune compétence ?", Categorie = "Erreur", Niveau = 0 }
                );
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Competence>> GetCompetences()
        {
            return _context.Competences.ToList();
        }
    }
}