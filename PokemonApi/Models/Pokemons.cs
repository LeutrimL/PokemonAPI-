using System.ComponentModel.DataAnnotations;

namespace PokemonApi.Models
{
    public class Pokemons
    {
        [Key]
        public int Id { get; set; }
        public List<Pokemons> Pokemon { get; set; }

        public string? Name { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public Pokemons(int id, string name, int height, int weight)
        {
            Id = id;
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}
