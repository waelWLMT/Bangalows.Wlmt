using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The bangalow.
    /// </summary>
    public class Bangalow : Entity
    {

        #region Properties
        /// <summary>
        /// Gets or sets the nom.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Gets or sets the adresse.
        /// </summary>
        public Adresse Adresse { get; set; }

        #endregion

        #region Navigation properties
        /// <summary>
        /// Gets or sets the proprietaire.
        /// </summary>
        public virtual Proprietaire Proprietaire { get; set; }

        /// <summary>
        /// Gets or sets the bangalow comercials.
        /// </summary>
        public virtual List<BangalowComercial> BangalowComercials { get; set; }
        /// <summary>
        /// Gets or sets the photos.
        /// </summary>
        public virtual List<Photo> Photos { get; set; }
        /// <summary>
        /// Gets or sets the reservations.
        /// </summary>
        public virtual List<Reservation> Reservations { get; set; }
        #endregion

    }
}
