using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The photo.
    /// </summary>
    public class Photo : Entity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the titre.
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the url photo.
        /// </summary>
        public string UrlPhoto { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to est CIN.
        /// </summary>
        public bool EstCIN { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to est CIN recto.
        /// </summary>
        public bool? EstCINRecto { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to est CIN verso.
        /// </summary>
        public bool? EstCINVerso { get; set; }
        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets the bangalow id.
        /// </summary>
        [ForeignKey(nameof(Bangalow))]
        public int?  BangalowId { get; set; }
        /// <summary>
        /// Gets or sets the bangalow.
        /// </summary>
        public virtual Bangalow? Bangalow { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }
        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        public virtual Client? Client { get; set; }
        #endregion
    }
}
