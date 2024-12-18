using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPF
{
    /// <summary>
    /// 启动时窗体的位置
    /// </summary>
    public enum StartPositionType
    {
        /// <summary>
        /// 由Location属性决定
        /// </summary>
        WindowLocation = 0,
        /// <summary>
        /// 窗体在屏幕中心
        /// </summary>
        CenterScreen=1,
    }
}
