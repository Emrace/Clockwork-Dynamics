using System;

class ParseURL
{
    static void Main()
    {
        Uri url = new Uri("http://www.devbg.org/forum/index.php");
        string[] segments = url.Segments;
        Console.WriteLine("[protocol] = \"{0}\"", url.Scheme);
        Console.WriteLine("[server] = \"{0}\"", url.Host);
        Console.WriteLine("[resource] = \"{0}\"", url.AbsolutePath);
    }
}