using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_cSharp
{
    public class SendViaEmail : Subscriber
    {
        private String emailAddr;

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void sendMsgViaMail(string msg)
        {
            Console.WriteLine("The message" + "\"" + msg +
                "\" has already sent to " + emailAddr);
        }

        public void Subscribe(Publisher pub)
        {
            pub.addToList(this, "email");
            pub.publishmsg += sendMsgViaMail;
            //Dictionary<string, SendViaEmail> emailDic = pub.getEmailDic();
            //String address = this.getEmailAddr();
            //SendViaEmail sendViaEmail = emailDic[this.getEmailAddr()];
            //pub.publishmsg += sendViaEmail.sendMsgViaMail;

            
            
        }

        public void Unsubscribe(Publisher pub)
        {
            
            Dictionary<string, SendViaEmail> emailDic = pub.getEmailDic();
            
            SendViaEmail sendViaEmail = emailDic[this.getEmailAddr()];
            pub.publishmsg -= sendViaEmail.sendMsgViaMail;

            pub.removeFromList(this, "email");
        
        }

        public string getIdentity()
        {
            return getEmailAddr();
        }

        public void sendMsg(string msg)
        {
            sendMsgViaMail(msg);
        }
    }
}
