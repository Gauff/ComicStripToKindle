using System.Net.NetworkInformation;

namespace ComicStripToKindle
{
    public static class Network
    {
        public static bool IsHostAvailable(string host)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(host);
                return reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
        }
    }
}
