using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKit.NovaPoshta.Client.Services
{
    public class NpBaseService : INpBaseService
    {
        private INovaPoshtaGateway _gateway;

        public NpBaseService(INovaPoshtaGateway gateway)
        {
            _gateway = gateway;
        }

        public INovaPoshtaGateway Gateway => _gateway;
    }
}
