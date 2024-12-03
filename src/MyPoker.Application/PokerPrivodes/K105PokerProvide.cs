using MyPoker.PokerProvide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyPoker.PokerPrivodes
{
    public class K105PokerProvide : PokerProvideAbstract
    {
        public override string Name => "K105";

        public async override Task OnConnectedAsync()
        {
            var buffer = new byte[1024 * 4];
            var receiveResult = await _Ws.ReceiveAsync(
                new ArraySegment<byte>(buffer), CancellationToken.None);

            while (!receiveResult.CloseStatus.HasValue)
            {
                await _Ws.SendAsync(
                    new ArraySegment<byte>(buffer, 0, receiveResult.Count),
                    receiveResult.MessageType,
                    receiveResult.EndOfMessage,
                CancellationToken.None);

                receiveResult = await _Ws.ReceiveAsync(
                    new ArraySegment<byte>(buffer), CancellationToken.None);
            }

            await _Ws.CloseAsync(
                receiveResult.CloseStatus.Value,
                receiveResult.CloseStatusDescription,
                CancellationToken.None);
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async override Task SendUserCommandAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}
