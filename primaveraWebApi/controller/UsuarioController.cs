using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using primaveraApi;
using primaveraApi.crud;
using primaveraApi.modelo;

namespace primaveraWebApi
{
    public class UsuarioController : ApiController
    {
        // Get api/artigo
        public List<Usuario> Get()
        {
            UsuarioCRUD clienteCrud = new UsuarioCRUD();
            List<Usuario> listaUsuario = clienteCrud.read();
            return listaUsuario;
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
