using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoker.Models
{
    public class OnActionOutput
    {
        /// <summary>
        /// 动作应答类型
        /// </summary>
        public string ActionReplyType { get; set; } = default!;

        /// <summary>
        /// 动作数据
        /// </summary>
        public object ActionData { get; set; } = default!;

        /// <summary>
        /// 动作token一次失效
        /// </summary>
        public string OpToken { get; set; } = default!;
    }
}
