using JogosApi.Models;
using JogosApi.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : BaseController<Jogo,JogoRepository>
    {
        
    }
}
