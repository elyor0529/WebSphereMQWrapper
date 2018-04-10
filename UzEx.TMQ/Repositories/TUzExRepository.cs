using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UzEx.TMQ.Helpers;
using UzEx.TMQ.Models;
using UzEx.TMQ.Services;

namespace UzEx.TMQ.Repositories
{
    public sealed class TUzExRepository : IDisposable
    {
        private MQAdapter _adapter;

        public TUzExRepository()
        {
            _adapter = new MQAdapter(MQConfig.QueueManagerName, MQConfig.ChannelInfo);
            _adapter.Open();
        }

        public CC_Info_Main ReceiveTResult(SE_Info_Main reciver)
        {
            var xml = IOHelper.XmlEncode(reciver);

            if (!_adapter.IsSuccess)
                throw new Exception(_adapter.ResultMessage);

            _adapter.Send(xml);

            CC_Info_Main sender = null;

            while (true)
            {
                _adapter.Receive();

                if (_adapter.IsSuccess)
                {
                    var result = _adapter.ResultMessage;

                    sender = IOHelper.XmlDecode<CC_Info_Main>(result);

                    if (sender != null)
                    {
                        break;
                    }
                }

                Thread.Sleep(100);
            }

            return sender;
        }

        public void SendUzExResult(TResult result)
        {
            var xml = IOHelper.XmlEncode(result);

            _adapter.Send(xml);
        }

        public void Dispose()
        {
            if (_adapter != null)
            {
                _adapter.Close();
                _adapter = null;
            }

            GC.SuppressFinalize(this);
        }

    }
}
