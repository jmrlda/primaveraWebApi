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
    public class VendedorController : ApiController
    {
        // Get api/vendedor
        public List<Vendedor> Get()
        {

            VendedorCrud vendedorCrud = new VendedorCrud();
            List<Vendedor> listaVendedor = vendedorCrud.read();
            return listaVendedor;
        }

        // Get api/vendedor/id
        public IEnumerable<String> Get(String id)
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
        public void Delete(int id)
        {

        }


    }
}
