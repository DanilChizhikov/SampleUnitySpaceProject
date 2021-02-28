namespace Data.Script.Core.Paterns.Singletone
{
    public interface ISingletone
    {
        bool IsActive { get; }

        void SingletoneAwake();
    }
}
