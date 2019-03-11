using System;
using System.Data;
using System.Collections.Generic;

using MySql.Data;
using MySql.Data.MySqlClient;

using static Pokedex.Pokemon;

namespace Pokedex
{
    public class Model 
    {    
        private List<Pokemon> pokemonList = new List<Pokemon>(); 
        private static string connString = "server=localhost;user=root;database=db;port3306;password=";
        private MySqlConnection conn = new MySqlConnection(connString);

    } 
}
