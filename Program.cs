using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

using static Pokedex.Pokemon;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon(1, "Bulbasaur", "Grass", 6.9, 0.7);
            Console.WriteLine(pokemon.GetBmi());
        }
    }
}
