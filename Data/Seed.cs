using System.Linq;
using dotnet_portfolio_api.Models;


//Créer les données
namespace dotnet_portfolio_api.Data
{
    public static class SeedData
    {
        public static void Initialize(PortfolioContext context)
        {
            //Si j'ai des données dans compétences
            if (context.Competences.Any())
                return;

            //Si je n'en ai pas je les créer
            context.Competences.AddRange(
                new Competence { Nom = "C#", Categorie = "Language", Niveau = 4 },
                new Competence { Nom = "Javascript", Categorie = "Language", Niveau = 4 }
            );

            context.SaveChanges();
        }
    }
}
