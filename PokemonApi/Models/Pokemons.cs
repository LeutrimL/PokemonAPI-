namespace PokemonApi.Models
{
    public class Root
    {
        public List<Pokemon> Users { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }

    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
    }

    public class PokemonViewModel
    {
        public Pokemon SelectedPokemon { get; set; }
    }
}
