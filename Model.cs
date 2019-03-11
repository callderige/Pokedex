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
        private List<Pokemon> pokemonList;
        private static string connString = "server=localhost;user=root;database=db;port3306;password=";
        private MySqlConnection conn = new MySqlConnection(connString);
        public void GetAllPokemon()
        {
            Pokemon pokemon = null;
            pokemonList = new List<Pokemon>(); 
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM Pokedex";
                MySqlCommand  cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {  
                    pokemon = new Pokemon((byte) rdr[1], (string) rdr[2], (string) rdr[3], (string) rdr[4], (double) rdr[5], (double) rdr[6]);
                    pokemonList.Add(pokemon);
                }
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }      
        public string GetPokemonList()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Kanto Id\tName\t\tTypes\t\tWeight (kg)\tHeight (m)");
            foreach (var item in pokemonList)
            {
                report.AppendLine($"{item.KantoId}\t\t{item.Name}\t{item.TypeOne}, {item.TypeTwo}\t{item.MetricWeight.ToString("#.##")}\t\t{item.MetricHeight.ToString("#.##")}\t");
            }

            return report.ToString();
        }
    } 
}
