using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ
{
    public struct MQConfig
    {

        public const string QueueManagerName = "SE";
         
        public const string ChannelInfo = "SVRCONN/TCP/127.0.0.1(1414)";

        public const string ReceiverQueueName = "FROM";

        public const string SenderQueueName = "TO";

    }
}
