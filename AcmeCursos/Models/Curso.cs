using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcmeCursos.Models
{
    [Table("Curso")]
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public String Nome { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name ="Descrição")]
        public String Descricao { get; set; }

        [Required]
        [Display(Name ="Data limite para inscrição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLimiteInscricao { get; set; }
    }
}