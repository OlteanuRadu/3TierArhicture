using Microsoft.Practices.Unity;

namespace Infrastructure
{
    public abstract class Module
    {
        public IUnityContainer UnityContainer { get; set; }
        public Module()
        {
            this.UnityContainer = new UnityContainer();
        }
        public abstract void RegisterTypes();
    }
}
