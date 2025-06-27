using Microsoft.EntityFrameworkCore;
using dotnet_portfolio_api.Models;

namespace dotnet_portfolio_api.Data
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

        public DbSet<Competence> Competences { get; set; }
    }
}