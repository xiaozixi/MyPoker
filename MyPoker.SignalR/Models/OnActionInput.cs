using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoker.Models
{
    public class OnActionInput
    {
        /// <summary>
        /// 操作token
        /// </summary>
        public string OpToken { get; set; } = default!;

        /// <summary>
        /// 动作请求类型
        /// </summary>
        public string ActionAskType { get; set; } = default!;

        /// <summary>
        /// 动作数据
        /// </summary>
        public object ActionData { get; set; } = default!;

        /// <summary>
        /// 房间id
        /// </summary>
        public Guid RoomId { get; set; }
    }
}
