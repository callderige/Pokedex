using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

using static Pokedex.Pokemon;
using static Pokedex.Model;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            Console.Write(m.GetAllPokemon());
        }
    }
}
