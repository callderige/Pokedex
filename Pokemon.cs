using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pokedex
{
    public class Pokemon 
    {
        public byte KantoId { get; set; }
        public string Name { get; set; }
        public string TypeOne { get; set; }
        public string TypeTwo { get; set; }
        public double MetricWeight { get; set; }
        public double MetricHeight { get; set; }
        public Pokemon(byte kantoId, string name, string typeOne, double metricWeight, double metricHeight)
        {
            this.KantoId = kantoId;
            this.Name = name;          
            this.TypeOne = typeOne;
            this.TypeTwo = "none";
            this.MetricWeight = metricWeight;
            this.MetricHeight = metricHeight;
        }
        public Pokemon(byte kantoId, string name, string typeOne, string typeTwo, double metricWeight, double metricHeight)
        {
            this.KantoId = kantoId;
            this.Name = name;            
            this.TypeOne = typeOne;
            this.TypeTwo = typeTwo;
            this.MetricWeight = metricWeight;
            this.MetricHeight = metricHeight;
        }
        public double GetBmi()
        {
            return this.MetricWeight / (this.MetricHeight*this.MetricHeight);
        }
    }
}
