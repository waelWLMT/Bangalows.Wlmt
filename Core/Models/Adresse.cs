using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Adresse : Entity
    {
        public int numero { get; set; }
        public string RueBoulevard { get; set; }
        public string Ville { get; set; }
        public bool EstRue { get; set; }
        public bool EstBoulevard { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
    }
}
