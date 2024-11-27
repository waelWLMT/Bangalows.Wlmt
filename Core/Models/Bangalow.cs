using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Bangalow : Entity
    {
        public string Nom { get; set; }        
        public Adresse Adresse { get; set; }
        public virtual List<Photo> Photos { get; set; }

    }
}
