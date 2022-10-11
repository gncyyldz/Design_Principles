using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_InDependency;
class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("filanca@falanca.com", "LayyHn");
    }
}
interface IMailServer
{
    void Send(string to, string body);
}
class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}
class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}