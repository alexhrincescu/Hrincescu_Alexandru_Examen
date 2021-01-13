using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrincescu_Alexandru_Examen.Models
{
    public class JocuriVideo
    {
        public int ID { get; set; }
        public string Titlu { get; set; }

        [Display(Name = "Data Lansării")]
        [DataType(DataType.Date)]
        public DateTime DataLansarii { get; set; }
        public string Gen { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Preţ { get; set; }
        public string Platforma { get; set; }
        public string Notă { get; set; }
    }
    

}
