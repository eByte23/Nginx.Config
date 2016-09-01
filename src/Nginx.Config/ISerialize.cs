using System;
using System.Text;

namespace Nginx.Config
{
    public interface ISerialize<T>
    {
        void Serialise(ref StringBuilder builder, T model);
    }

    public class Serialize<T> : ISerialize<T>
    {
        public virtual void Serialise(ref StringBuilder builder, T model)
        {
            
        }
    }
}