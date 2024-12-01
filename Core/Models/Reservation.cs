using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The reservation.
    /// </summary>
    public class Reservation : Entity
    {

        #region Properties
        /// <summary>
        /// Gets or sets the date debut.
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Gets or sets the date fin.
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// Gets or sets the heure entree.
        /// </summary>
        public TimeSpan HeureEntree { get; set; }
        /// <summary>
        /// Gets or sets the heure sortie.
        /// </summary>
        public TimeSpan HeureSortie { get; set; }
        /// <summary>
        /// Gets or sets the nbr jours.
        /// </summary>
        public double NbrJours { get; set; }

        #endregion

        #region Navigation properties      

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Gets or sets the bangalow id.
        /// </summary>
        public int BangalowId { get; set; }

        /// <summary>
        /// Gets or sets the bangalow.
        /// </summary>
        public virtual Bangalow Bangalow { get; set; }
        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        public virtual Client Client { get; set; }       

        #endregion

    }
}
