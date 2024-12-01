﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The client.
    /// </summary>
    public class Client : User
    {
        #region Properties
        /// <summary>
        /// Gets or sets the nom.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Gets or sets the prenom.
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Gets or sets the CIN.
        /// </summary>
        public string CIN { get; set; }
        /// <summary>
        /// Gets or sets the tel.
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Gets or sets the adresse mail.
        /// </summary>
        public string AdresseMail { get; set;}
       

        #endregion

        #region Navigation properties
        /// <summary>
        /// Gets or sets the reservations.
        /// </summary>
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Photo> CINPhotos { get; set; }
        #endregion

    }
}
