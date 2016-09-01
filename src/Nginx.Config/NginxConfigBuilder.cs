using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nginx.Config
{
    public class NginxConfigBuilder
    {
        private VirtualHostBuilder _vhostBuilder = new VirtualHostBuilder();
        private List<VirtualHost> _virtualHosts = new List<VirtualHost>();

        //public NginxConfigBuilder AddVirtualHost(Action<VirtualHostBuilder> vhostBuilderAction)
        //{
        //    //vhostBuilderAction()
        //    return this;
        //}

        public NginxConfigBuilder AddVirtualHost(Action<VirtualHost> vhostAction)
        {
            var vhost = new VirtualHost();
            vhostAction(vhost);
            _virtualHosts.Add(vhost);
            //vhostBuilderAction()
            return this;
        }

        public string Build()
        {
            var sb = new StringBuilder();

            var serailizer = new SerializeManager()
                .FindAll();

            _virtualHosts.ForEach(x =>
            {
                serailizer.Send(ref sb, x);
            });

            //serailizer.Send(ref sb, _virtualHosts);

            return sb.ToString();
        }
    }
}
