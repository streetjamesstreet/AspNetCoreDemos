using System.Collections.Generic;

namespace AspNetCoreDemos.Models
{
    public class PopulationUSA
    {
        public PopulationUSA(string name, int value)
        {
            Name = name;
            Value = value;
            Items = new List<PopulationUSA>();
        }

        public string Name { get; set; }
        public int Value { get; set; }

        public List<PopulationUSA> Items { get; set; }
    }
}
