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
            _context.Competences.RemoveRange(_context.Competences);


            // Si aucune compétence ajoutée 
            if (!_context.Competences.Any())
            {
                //J'ajoute des données dans la mémoire (seulement en RAM)
                _context.Competences.AddRange(
                    new Competence { Nom = "C#", Categorie = "Language", Niveau = 4 },
                    new Competence { Nom = "Javascript", Categorie = "Language", Niveau = 4 }

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