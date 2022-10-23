using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_NotIdealCode;
class MailService
{
    public void SendMail(Gmail gmail)
    {
        gmail.Send("...");
    }
}

class Gmail
{
    public void Send(string mail)
    {
        //...Send Mail...
    }
}
class Yandex
{
    public void SendMail(string mail, string to)
    {
        //...Send Mail...
    }
}
class Hotmail
{
    public void Send(string mail)
    {
        //...Send Mail...
    }
}