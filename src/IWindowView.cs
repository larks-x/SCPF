namespace SCPF
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWindowView
    {
        int Width { get; }
        int Height { get; }
        int Left { get; }
        int Top { get; }
        void Create();

    }
}
