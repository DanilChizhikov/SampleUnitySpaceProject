namespace Data.Script.Core
{
    public interface IBaseUpdater
    {
        bool IsActive { get; set; }

        void BaseAwake();
        void BaseUpdate();

        void SetActive(bool isFlag);
    }
}
