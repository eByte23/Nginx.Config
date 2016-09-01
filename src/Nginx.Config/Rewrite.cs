using System;
using System.Text;

namespace Nginx.Config
{
    [Config(Type = ConfigType.MultiLine)]
    public class Rewrite
    {
        public Rewrite() { }

        public Rewrite(string matchPath, string rewriteToPath)
        {
            MatchPath = matchPath;
            RewriteToPath = rewriteToPath;
        }

        public string MatchPath { get; set; }
        public string RewriteToPath { get; set; }
    }

    public class RewriteSerializer : Serialize<Rewrite>
    {
        public override void Serialise(ref StringBuilder builder, Rewrite model)
        {

        }
    }
}