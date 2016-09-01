using Nginx.Config;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var configs = new NginxConfigBuilder()
                .AddVirtualHost(x =>
                {
                    x.ServerName = new[] { "domain.com", "example.com" };
                    x.Listen = new long[] { 80, 443 };
                    //x.Port = 80;
                    x.Locations = new Location[]
                        {
                            new Location
                            {
                                Path = "/foo",
                                LocationConfigProps = new LocationProperties
                                {
                                    Root = "/var/www/html",
                                    Index = new[] { "index.html", "index.php" },
                                    //l.ProxyPass("http://127.0.0.1:81/bar");
                                    //l.SetHeaders(new {"" ,""}, new {"" ,""} );
                                    Rewrite = new[] { new Rewrite(@"^/(\d+)", "/foo/bar?id=$1") }
                                }
                            },
                            new Location
                            {
                                Path = @"/foo/bar?id=\d+",
                                //echo "Holy foobar!";
                            }
                    
                
                        };
                });
        }
    }
}