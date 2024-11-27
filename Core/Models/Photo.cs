using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Photo : Entity
    {
        #region Properties
        public string Titre { get; set; }
        public string Description { get; set; }
        public string UrlPhoto { get; set; }
        #endregion
    }
}
