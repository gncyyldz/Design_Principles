using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Dependency;
class MailSender
{
    public void Send()
    {
        //Gmail gmail = new();
        //gmail.Send("gyildizmail@gmail.com");
        Hotmail hotmail = new();
    }
}
class Gmail
{
    public Gmail()
    {

    }
    public void Send(string to)
    {
        //...
    }
}
class Hotmail
{

}