using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_cSharp
{
    public class SendViaMobile:Subscriber
    {
        private String cellPhone;

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        public void sendMsgViaMobile(string msg)
        {
            Console.WriteLine("The message " + "\"" + msg + "\" has already texted to " + cellPhone);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMsgViaMobile;
            pub.addToList(this, "mobile");
        }

        public void Unsubscribe(Publisher pub)
        {

            Dictionary<string, SendViaMobile> phoneDic = pub.getPhoneDic();

            SendViaMobile sendViaMobile = phoneDic[this.getMobile()];
            pub.publishmsg -= sendViaMobile.sendMsgViaMobile;
            
            pub.removeFromList(this, "mobile");
        }



        public string getIdentity()
        {
            return getMobile();
        }

        public void sendMsg(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
