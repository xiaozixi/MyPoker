using MyPoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.DependencyInjection;

namespace MyPoker.Hubs
{
    public abstract class PokerHubAbstract : AbpHub, ITransientDependency
    {
        public abstract Task<OnActionOutput> OnActionAsync(OnActionInput input);
    }
}
