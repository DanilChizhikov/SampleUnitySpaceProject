namespace Data.Script.Core.Paterns.Singletone
{
    public class SingletoneBase : BaseObject, ISingletone
    {
        public virtual void SingletoneAwake() { }

        public override void BaseAwake()
        {
            SingletoneAwake();
        }

        public override void BaseUpdate()
        {}
    }
}
