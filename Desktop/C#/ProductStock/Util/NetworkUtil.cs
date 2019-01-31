using System.Net;
using System.Net.Sockets;

namespace Util
{
    public class NetworkUtil
    {
        public static string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    if (ip.ToString().StartsWith("10.45."))
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            return localIP;
        }
    }
}
