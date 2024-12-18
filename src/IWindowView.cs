using System.Drawing;

namespace SCPF
{
    /// <summary>
    /// 
    /// </summary>
    internal interface IWindowView : IDisposable
    {
        int Width { get; }
        int Height { get; }
        int Left { get; }
        int Top { get; }

        Point Location { get; set; }

        Size Size { get; set; }
        bool Visible { get; set; }
        string Title { get; set; }

        bool Enable { get; set; }

        byte[] RawIcon { get; set; }

        void Create(WindowOption option);

        void Show();

        void Hide();
        void Close();
        void ShowDialog();

    }
}
