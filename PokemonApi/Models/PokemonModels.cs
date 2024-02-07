namespace PokemonApi.Models
{
    public class PokemonDetails
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public PokemonDetails(int id, string name, int height, int weight)
        {
            Id = id;
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}
