using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Read
{
    /// <summary>
    /// The admin read data transfer object.
    /// </summary>
    public class AdminReadDto : UserReadDto
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the crypted password.
        /// </summary>
        public string CryptedPassword { get; set; }

        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets  a value indicating whether to est active.
        /// </summary>
        public bool EstActive { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public RoleReadDto Role { get; set; }
        #endregion
    }
}
