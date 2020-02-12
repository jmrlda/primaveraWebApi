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
        // Get api/encomenda
        public List<Encomenda> Get()
        {   
            EncomendaCRUD clienteCrud = new EncomendaCRUD();
            List<Encomenda> listaEncomenda = clienteCrud.read();
            return listaEncomenda;
        }

        // Get api/encomenda/id
        public IEnumerable<String> Get(int id)
        {
            return new string[] { "ola", "mundo" };
        }

        // POST api/encomenda
        [HttpPost]
        public bool Post([FromBody]  Encomenda encomenda)
        {
            Console.WriteLine("Post Encomenda");
            EncomendaCRUD encomendaCRUD = new EncomendaCRUD();
            bool rv = encomendaCRUD.create(encomenda);

            return rv;
          
        }

        // PUT api/encomenda/id
        public void put(int id, [FromBody]string value)
        {

        }

        //DELETE api/encomenda/id
        public void Delete(int id )
        {

        }

    }
}
