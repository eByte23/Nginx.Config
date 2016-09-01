namespace Nginx.Config
{
    public class LocationProperties
    {
        public string Root { get; set; }
        public string[] Index { get; set; }
        public Rewrite[] Rewrite { get; set; }
    }
}