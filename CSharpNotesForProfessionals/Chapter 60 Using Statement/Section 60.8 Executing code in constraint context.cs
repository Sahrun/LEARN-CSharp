using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_8
{
    public static class SSLContext
    {

        public delegate void TunnelRutine(BinaryReader sslReader, BinaryWriter sslWriter);

        public static void ClientTunnel(TcpClient tcpClient, TunnelRutine routine)
        {
            using (SslStream sslStream = new SslStream(tcpClient.GetStream(), true))
            {
                sslStream.AuthenticateAsClient("HOStNAMEs", null, SslProtocols.Tls, false);

                if (!sslStream.IsAuthenticated)
                {
                    throw new SecurityException("SSL tunnel not authenticated");
                }
                if (!sslStream.IsEncrypted)
                {
                    throw new SecurityException("SSL tunnel not encryped");
                }

                using (BinaryReader sslReader = new BinaryReader(sslStream))
                using (BinaryWriter sslWriter = new BinaryWriter(sslStream))
                {
                    routine(sslReader, sslWriter);
                }
            }
        }
    }
}
