using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Client : Entity
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string Tel { get; set; }
        public string AdresseMail { get; set;}
        public Photo RectoCIN { get; set; }
        public Photo VersoCIN { get; set; }

    }
}
