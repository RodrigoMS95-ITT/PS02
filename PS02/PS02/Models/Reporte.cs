using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS02.Models
{
    public class Reporte
    {
        public int ID { get; set; }

        [Required]
        public string Cliente { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        [Required]
        public string Estatus { get; set; }

        public int MenuID { get; set; }
        [ForeignKey("MenuID")]

        public Menu Menu { get; set; }
    }
}