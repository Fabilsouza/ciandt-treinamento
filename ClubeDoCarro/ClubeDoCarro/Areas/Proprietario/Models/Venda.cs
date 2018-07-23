using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubeDoCarro.Areas.Proprietario.Models
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int VendaId { get; set; }
        [Required]
        public int VeiculoId { get; set; }
        [Required]
        public int UsuarioVenda { get; set;  }
        [Required]
        public int UsuarioCompra { get; set; }
        [Required]
        public DateTime DataVenda { get; set; }
        [Required]
        public double ValorVenda { get; set; }
    }
}