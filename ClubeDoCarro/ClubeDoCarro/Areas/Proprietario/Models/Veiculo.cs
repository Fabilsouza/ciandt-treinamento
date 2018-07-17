using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClubeDoCarro.Areas.Proprietario.Models
{
    public class Veiculo
    {    
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required ()]
        public string Cor { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int Ano { get; set; }
        public string Complemento { get; set; }
        public string Carroceria { get; set; }
        [Required]
        public string Chassi { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        public int Km { get; set; }
        [Required]
        public int Portas { get; set; }
        [Required]
        public string Combustivel { get; set; }
    }
}