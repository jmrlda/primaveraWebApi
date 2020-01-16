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
        }

        public void Stop()
        {
            _webapp?.Dispose();
        }

      
    }
}
