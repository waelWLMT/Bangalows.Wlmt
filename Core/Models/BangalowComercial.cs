using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The bangalow comercial.
    /// </summary>
    public class BangalowComercial
    {
        #region Properties
        #endregion

        #region Navigation properties
        /// <summary>
        /// Gets or sets the bangalow id.
        /// </summary>
        public int BangalowId { get; set; }
        /// <summary>
        /// Gets or sets the comercial id.
        /// </summary>
        public int ComercialId { get; set; }

        /// <summary>
        /// Gets or sets the bangalow.
        /// </summary>
        public virtual Bangalow Bangalow { get; set; }
        /// <summary>
        /// Gets or sets the commercial.
        /// </summary>
        public virtual Commercial Commercial { get; set; }
        #endregion
    }
}
