using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosApi.Models
{
    [Table("Jogos")]
    public class Jogo : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Lancamento { get; set; }
    }
}
