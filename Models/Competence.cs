namespace dotnet_portfolio_api.Models
{
    public class Competence
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public required string Categorie { get; set; }
        public int Niveau { get; set; }
    } 
}