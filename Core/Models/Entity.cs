using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The entity.
    /// </summary>
    public class Entity
    {
        #region properties
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        public int? CreatedBy { get; set; } 
        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        public int? UpdatedBy { get; set; }
        #endregion
    }
}
