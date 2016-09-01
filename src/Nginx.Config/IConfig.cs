using System;

namespace Nginx.Config
{
    public interface IConfig<T>
    {
        string Serialize(T config);
    }

    public class Config<T> : IConfig<T>
    {
        public virtual string Serialize(T config)
        {

            return "";
        }
    }
}