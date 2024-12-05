using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Create
{
    public class UserCreateDto : EntityCreateDto
    {

        #region properties

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Tel2 { get; set; }
        public string CIN { get; set; }
        public bool EstActive { get; set; }
        public string NumeroWhatsApp { get; set; }
        #endregion

        #region Navigation properties

        public int RoleId { get; set; }

        #endregion


    }
}
