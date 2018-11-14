using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyBasketball.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public string positionCode { get; set; }
        public string positionDescription { get; set; }
    }
}