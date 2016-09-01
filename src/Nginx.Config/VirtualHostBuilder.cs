using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nginx.Config
{
    public class VirtualHostBuilder
    {
        private VirtualHost _virtualHost = new VirtualHost();

        public VirtualHostBuilder ServerNames(params string[] domainNames)
        {
            //ServerName[ServerName.Length] = domainNames;

            return this;
        }

        public VirtualHostBuilder Ports(params long[] ports)
        {
           // this.Listen[] = ports;
            return this;
        }

        public VirtualHostBuilder Location(string uriPath, LocationProperties locationProps)
        {
            //this.Locations.Add(uriPath, locationProps);
            return this;
        }

        public VirtualHostBuilder Location(string uriPath, Action<LocationProperties> locationProps)
        {
            var props = new LocationProperties();

            locationProps(props);

           // this.Locations.Add(uriPath, props);
            return this;
        }

        public VirtualHostBuilder Locations(params Location[] locations)
        {
            //   this.Locations.Addrange(locations);
            return this;
        }

        public VirtualHost Build()
        {
            return _virtualHost;
        }

        public void Clean()
        {
            _virtualHost = new VirtualHost();
        }
    }
}
