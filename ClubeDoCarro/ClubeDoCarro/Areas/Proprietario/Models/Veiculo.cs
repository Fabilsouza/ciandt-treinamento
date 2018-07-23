using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubeDoCarro.Areas.Proprietario.Models
{
    public class Veiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int VeiculoID { get; set; }
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
        [Display(Name = "Disponível para Venda")]
        public Boolean DisponivelVenda { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DataAquisicao { get; set; }

    }
}