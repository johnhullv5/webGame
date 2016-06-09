using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace advanced_cSharp
{
    public class Publisher
    {


        private Dictionary<string, SendViaEmail> emailDic;

        public Dictionary<string, SendViaEmail> getEmailDic()
        {
            return emailDic;
        }

        private Dictionary<string, SendViaMobile> cellPhoneDic;

        public Dictionary<string, SendViaMobile> getPhoneDic()
        {
            return cellPhoneDic;
        }

        public delegate void PublishMessageDel(string msg);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        private string pub_name;



        public Publisher(string name)
        {
            emailDic = new Dictionary<string, SendViaEmail>();
            cellPhoneDic = new Dictionary<string, SendViaMobile>();
            this.pub_name = name;

        }

        public void addToList(Subscriber subscriber, string infoType)
        {
            switch (infoType)
            {
                case "email":
                    if (!emailDic.ContainsKey(subscriber.getIdentity()))
                        emailDic.Add(subscriber.getIdentity(), (SendViaEmail)subscriber);
                    break;
                case "mobile":
                    if (!cellPhoneDic.ContainsKey(subscriber.getIdentity()))
                        cellPhoneDic.Add(subscriber.getIdentity(), (SendViaMobile)subscriber);
                    break;
                default:
                    Console.WriteLine("wrong infoType");
                    break;

            }


        }

        public void removeFromList(Subscriber subscriber, string infoType)
        {
            switch (infoType)
            {
                case "email":
                    if (emailDic.ContainsKey(subscriber.getIdentity()))
                        emailDic.Remove(subscriber.getIdentity());
                    break;

                case "mobile":
                    if (cellPhoneDic.ContainsKey(subscriber.getIdentity()))
                        cellPhoneDic.Remove(subscriber.getIdentity());
                    break;
                default:
                    Console.WriteLine("wrong infoType");
                    break;

            }


        }

        public int getEmailNumber()
        {
            return emailDic.Count;
        }

        public int getCellPhoneNumber()
        {
            return cellPhoneDic.Count;
        }


        public void PublishMessage(string message)
        {

            if (publishmsg != null)
            {
                publishmsg.Invoke(message);

                MessageBox.Show(message + "  published!");
            }

            else {
                MessageBox.Show("No subscribers!");

            }
        }
    }
}
