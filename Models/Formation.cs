namespace dotnet_portfolio_api.Models
{
    public class Formation
    {
        public int Id { get; set; }
        public required string Ecole { get; set; }
        public required int DateDebut { get; set; }
        public int DateFin { get; set; }
        public required string Intitule { get; set; }
        public required string Ville { get; set; }
    }
}