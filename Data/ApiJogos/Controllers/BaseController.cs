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
    public abstract class BaseController<M, R>: ControllerBase where M:BaseModel where R:BaseRepository<M>
    {
        R repo = Activator.CreateInstance<R>();

        [HttpPost]                                                              //Create
        public void Post([FromBody]M model)
        {
            repo.Create(model);
        }

        [HttpGet]                                                               //Read
        public List<M> Get()
        {
            return repo.Read();
        }

        [HttpGet("{id}")]                                                       //Read(id)
        public M Get(int id)
        {
            return repo.Read(id);
        }

        [HttpPut("{id}")]                                                       //Update
        public void Put(int id,[FromBody]M model)
        {
            model.Id = id;
            repo.Update(model);
        }

        [HttpDelete("{id}")]                                                    //Delete
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
