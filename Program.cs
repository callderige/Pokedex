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
            Pokemon p = m.GetOnePokemon(12);
            p.Name = "testing";
            m.UpdateOnePokemon(p);
        }
    }
}
