using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The admin.
    /// </summary>
    public class Admin : User
    {
        #region properties
        /// <summary>
        /// Gets or sets the nom.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Gets or sets the prenom.
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Gets or sets the tel1.
        /// </summary>
        public string Tel1 { get; set; }
        /// <summary>
        /// Gets or sets the tel2.
        /// </summary>
        public string Tel2 { get; set; }
        #endregion

        #region Navigation properties        

        #endregion
    }
}
