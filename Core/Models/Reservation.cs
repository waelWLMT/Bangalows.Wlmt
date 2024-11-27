using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Reservation : Entity
    {

        #region Properties
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public TimeSpan HeureEntree { get; set; }
        public TimeSpan HeureSortie { get; set; }
        public double NbrJours { get; set; }

        #endregion


        #region Navigation properties

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        [ForeignKey(nameof(Bangalow))]
        public int BangalowId { get; set; }

        public virtual Bangalow Bangalow { get; set; }
        public virtual Client Client { get; set; }
        public virtual User User { get; set; }


        #endregion

    }
}
