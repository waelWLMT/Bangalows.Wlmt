using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The proprietaire.
    /// </summary>
    public class Proprietaire : User
    {
        #region properties       
        /// <summary>
        /// Gets or sets the tel2.
        /// </summary>
        public string Tel2 { get; set; }

        /// <summary>
        /// Gets or sets the numero whats app.
        /// </summary>
        public string NumeroWhatsApp { get; set; }
        #endregion

        #region navigation properties
        /// <summary>
        /// Gets or sets the bangalows.
        /// </summary>
        public virtual  List<Bangalow> Bangalows { get; set; }
        #endregion
    }
}
