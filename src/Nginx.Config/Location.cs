using System.Text;

namespace Nginx.Config
{
    public class Location : Config<Location>
    {
        public Location() { }

        public Location(string path, LocationProperties locationConfigProps)
        {
            Path = path;
            LocationConfigProps = locationConfigProps;
        }

        public string Path { get; set; }
        public LocationProperties LocationConfigProps { get; set; }

    }

    public class LocationSerializer : Serialize<Location>
    {
        public override void Serialise(ref StringBuilder builder, Location model)
        {
            base.Serialise(ref builder, model);
        }
    }
}