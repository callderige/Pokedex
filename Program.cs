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
            //Pokemon p = new Pokemon(3, "Venusaur", "Grass", "Poison", 100, 2);
            //m.InsertPokemon(p);
            //Console.Write(m.GetAllPokemon());
            Pokemon p = m.GetOnePokemon(12);
            p.Name = "testing";
            m.UpdateOnePokemon(p);
        }
    }
}
