using System;
using Microsoft.Owin.Hosting;

namespace primaveraWebApi
{
    public class Webserver
    {
        private IDisposable _webapp;

        public void Start()
        { 
            _webapp = WebApp.Start<Startup>("http://*:9191");
            //Init.TabelaUtilizador();
            //Init.TabelaEncomenda();
            //Init.TabelaItemEncomenda();
        }

        public void Stop()
        {
            _webapp?.Dispose();
        }

      
    }
}
