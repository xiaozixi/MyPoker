using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.DependencyInjection;

namespace MyPoker.Hubs
{
    [HubRoute("/game-room")]
    public class GameRoomHub : AbpHub, ITransientDependency
    {
        public async Task SendMessage(int[] pokerIndexs, string pokerPushToken)
        {
            await Task.CompletedTask;
            var currentUserName = CurrentUser.UserName; //Access to the current user info
        }
    }
}
