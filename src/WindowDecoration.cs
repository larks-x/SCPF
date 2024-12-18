using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPF
{
    /// <summary>
    /// 窗体装饰
    /// </summary>
    public struct WindowDecoration
    {
        /// <summary>
        /// 可调整大小
        /// </summary>
        public WindowFrameType WindowFrames  { get; set; }
        /// <summary>
        /// 启用最大化按钮
        /// </summary>
        public bool EnableMaximizeButton { get; set; }
        /// <summary>
        /// 启用最小化或还原按钮
        /// </summary>
        public bool EnableMinimizeOrRestoreButton { get; set; }
        /// <summary>
        /// 启用关闭按钮
        /// </summary>
        public bool EnableCloseButton { get; set; }
        /// <summary>
        /// 显示图标
        /// </summary>
        public bool ShowIcon { get; set; }
        
    }
}
