// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Text;

Ping pingSender = new Ping();
PingOptions options = new PingOptions();

string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "8.8.8.8";
PingReply reply = pingSender.Send(address,timeout,buffer,options);
if (reply.Status == IPStatus.Success)
{
    Console.WriteLine("Status {0}", reply.Status.ToString());
}

;
