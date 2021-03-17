using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR.Client;

namespace PetConn.WinUI
{
    class SignalRClient
    {
        private HubConnection _conn;
        public SignalRClient(HubConnection conn)
        {
            _conn = conn;
        }
        public void nesto()
        {
            _conn = new HubConnectionBuilder().WithUrl("nesto").Build();
           // _conn.SendAsync("")
        }
    }
}
