using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClubeDoCarro.Areas.Oficina.Models
{
    public class Oficina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int OficinaID { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public int Cnpj { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public int Telefone { get; set; }
        [Required]
        public String Endereco { get; set; }

    }
}