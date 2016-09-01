using System;

namespace Nginx.Config
{
    internal class ConfigAttribute : Attribute
    {
        public ConfigType Type { get; set; } = ConfigType.SingleLine;
    }

    public enum ConfigType
    {
        SingleLine = 1,
        MultiLine = 2
    }
}