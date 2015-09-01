using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcmeCursos.Models
{

    [Table("professor")]
    public class Professor
    {

        [Key]
        public int Id { get; set; }


    }
}