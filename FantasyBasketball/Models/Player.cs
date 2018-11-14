using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyBasketball.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int playerID { get; set; }
        public string playerLastName { get; set; }
        public string playerFirstName { get; set; }

        [ForeignKey("Position")]
        public virtual string positionCode { get; set; }
        public virtual Position Position { get; set; }

        [ForeignKey("Team")]
        public virtual int teamID { get; set; }
        public virtual Team Team { get; set; }
    }
}