using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClubeDoCarro.Models
{
    public class ClubeDoCarroContext : DbContext
    {
    
        public ClubeDoCarroContext() : base("name=ClubeDoCarroContext")
        {
        }

        public System.Data.Entity.DbSet<ClubeDoCarro.Areas.Proprietario.Models.Veiculo> Veiculos { get; set; }
    }
}
