using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPF
{
    /// <summary>
    /// 边框类型
    /// </summary>
    public enum WindowFrameType
    {
        /// <summary>
        /// 没有边框
        /// </summary>
        None=0,
        /// <summary>
        /// 单边框,此模式不可调整大小
        /// </summary>
        SingleBorder=1,
        /// <summary>
        /// 具有可调整窗体大小边框
        /// </summary>
        Resizable=2,
    }
}
