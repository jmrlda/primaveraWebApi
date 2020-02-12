using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using primaveraApi.crud;
using primaveraApi.modelo;
using System.Net.Http.Headers;

namespace primaveraWebApi
{
    public class ArtigoController : ApiController
    {
        // Get api/teste
        public List<Artigo> Get()
        {

            ArtigoCRUD artigoCrud = new ArtigoCRUD();
            List<Artigo> listaArtigo = artigoCrud.read();
            return listaArtigo;
        }

        // Get api/artigo/id
        public IEnumerable<String> Get(int id)
        {


            return new string[] { "ola", "mundo" };
        }

        // POST api/artigo
        public void Post([FromBody] String value)
        {
            Console.WriteLine("value");
            Console.WriteLine(value);
        }

        // PUT api/artigo/id
        public void Put(int id, [FromBody]string value)
        {

        }

        //DELETE api/artigo/id
        public void Delete(int id )
        {

        }


    }
}
