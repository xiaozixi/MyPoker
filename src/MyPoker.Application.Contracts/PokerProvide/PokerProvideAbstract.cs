using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MyPoker.PokerProvide
{
    public abstract class PokerProvideAbstract
    {
        protected Guid _RoomId;
        protected WebSocket _Ws;

        public abstract string Name { get; }

        public abstract Task SendUserCommandAsync();

        public virtual async Task InitPokerAsync(Guid roomId, WebSocket ws)
        {
            _RoomId = roomId;
            _Ws = ws;
            await Task.CompletedTask;
        }

        public abstract Task OnConnectedAsync();

        public abstract Task OnDisconnectedAsync(Exception? exception);
    }
}
