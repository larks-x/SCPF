using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPF
{
    /// <summary>
    /// 创建时窗体的设置
    /// </summary>
    public struct WindowOption
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 窗体创建后需要为哪个渲染后端创建相应环境
        /// </summary>
        public GraphicsBackend Backend { get; set; }
        /// <summary>
        /// 装饰
        /// </summary>
        public WindowDecoration Decoration { get; set; }
        /// <summary>
        /// 此窗体为具有透明缓冲帧的窗体(为OpenGL创建透明缓冲帧)
        /// </summary>
        public bool TransparentWindow { get; set; }
        /// <summary>
        /// 左上角所在位置
        /// </summary>
        public Point Location { get; set; }
        /// <summary>
        /// 初始的大小
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// 窗体初始化位置
        /// </summary>
        public StartPositionType StartPosition { get; set; }
    }
}
