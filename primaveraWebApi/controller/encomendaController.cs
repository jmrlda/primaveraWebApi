using primaveraApi.crud;
using primaveraApi.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace primaveraWebApi
{
    public class EncomendaController : ApiController
    {
        // Get api/teste
        public List<Encomenda> Get()
        {
            EncomendaCRUD clienteCrud = new EncomendaCRUD();
            List<Encomenda> listaEncomenda = clienteCrud.read();
            return listaEncomenda;
        }

        // Get api/artigo/id
        public IEnumerable<String> Get(int id)
        {
            return new string[] { "ola", "mundo" };
        }

        // POST api/artigo
        public void Post([FromBody] String value)
        {

        }

        // PUT api/artigo/id
        public void put(int id, [FromBody]string value)
        {

        }

        //DELETE api/artigo/id
        public void Delete(int id )
        {

        }

    }
}
