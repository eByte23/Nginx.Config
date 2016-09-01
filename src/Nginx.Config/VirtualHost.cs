using System;
using System.Collections.Generic;
using System.Text;

namespace Nginx.Config
{
    [Config(Type = ConfigType.MultiLine)]
    public class VirtualHost : Config<VirtualHost>
    {
        [Config(Type = ConfigType.SingleLine)]
        public string[] ServerName { get; set; }

        [Config(Type = ConfigType.MultiLine)]
        public long[] Listen { get; set; }

        [Config(Type = ConfigType.MultiLine)]
        public Location[] Locations { get; set; }
    }

    public class VirtualHostSerializer : Serialize<VirtualHost>
    {
        public override void Serialise(ref StringBuilder builder, VirtualHost model)
        {
            base.Serialise(ref builder, model);
        }
    }
}