
using Topshelf;
namespace primaveraWebApi
{
    class Program
    {
        static void Main(string[] args)
        {


            HostFactory.Run(x =>
            {
                x.Service<Webserver>(s =>
                {
                    s.ConstructUsing(name => new Webserver());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());

                });
                x.RunAsLocalSystem();
                x.SetDescription("primavera service webapi");
                x.SetDisplayName("primavera WebApi");
                x.SetServiceName("primaveraWebApi");
            });



        }
    }
}
