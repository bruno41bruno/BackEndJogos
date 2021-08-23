using JogosApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosApi.Context
{
    public class DbJogos : DbContext
    {
        public DbSet<Jogo> Jogo { get; set; }
        public DbJogos():base("Data Source=192.168.0.140;Initial Catalog=ProjetoBruno;Persist Security Info=True;User ID=Bruno;Password=@123")
        {

        }
    }
}
