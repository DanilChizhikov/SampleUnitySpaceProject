namespace Data.Script.Core.Scene
{
    public interface IPause
    {
        bool IsPaused { get; set; }

        void Pause();
    }
}
