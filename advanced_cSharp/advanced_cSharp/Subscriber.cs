using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_cSharp
{
    public interface Subscriber
    {
        void Subscribe(Publisher pub);

        void Unsubscribe(Publisher pub);

        void sendMsg(string msg);

        string getIdentity();
    }
}
